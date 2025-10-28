using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CasterServer.Application;
using CasterServer.Mountpoint;
using System.Runtime.CompilerServices;
using RtcmSharp;
using RtkMathLib;
using CasterServer.Client;

namespace CasterServer.GUI
{
    [ApiController]
    [Route("api/[controller]")]
    public class CasterController : ControllerBase
    {
        private readonly MountpointManager m_MountpointManager;
        private readonly ClientManager m_ClientManager;
        public CasterController(MountpointManager mountpointManager, ClientManager clientManager)
        {
            m_MountpointManager = mountpointManager;
            m_ClientManager = clientManager;
        }

        [HttpGet("mountpointList")]
        public IActionResult GetMountpoints()
        {
            var mountpoints = m_MountpointManager.GetMountpoints();
            Console.WriteLine(mountpoints.Count);
            var stations = new List<MountpointInfoDTO>();

            foreach (var kvp in mountpoints)
            {
                var name = kvp.Key;
                var info = kvp.Value.m_Info;

                stations.Add(new MountpointInfoDTO
                {
                    m_Name = name,
                    m_Identifier = info.m_Identifier,
                    m_Format = info.m_Format,
                    m_FormatDetails = info.m_FormatDetails,
                    m_Carrier = info.m_Carrier,
                    m_NavSystem = info.m_NavSystem,
                    m_Network = info.m_Network,
                    m_Country = info.m_Country,
                    m_Lat = info.m_Coordinate.m_Latitude,
                    m_Lon = info.m_Coordinate.m_Longitude
                });
            }

            return Ok(new { stations = stations });
        }

        [HttpGet("nearestMountpoints")]
        public IActionResult GetNearestMountpoints([FromQuery] double Latitude, [FromQuery] double Longitude, [FromQuery] int NumberOfMountpoints)
        {
            var mountpoints = m_MountpointManager.SearchNearestMountpoints(NumberOfMountpoints, new LatLonAlt { m_Latitude = Latitude, m_Longitude = Longitude });
            return Ok(new { mountpoints = mountpoints });
        }

        [HttpGet("nearestMountpointsWithinRadius")]
        public IActionResult GetNearestMountpointsWiithinRadius([FromQuery] double Latitude, [FromQuery] double Longitude, [FromQuery] double RadiusInKilometer)
        {
            var mountpoints = m_MountpointManager.SearchNearestMountpointsWithinRadius(RadiusInKilometer, new LatLonAlt { m_Latitude = Latitude, m_Longitude = Longitude });
            return Ok(new { mountpoints = mountpoints });
        }

        [HttpGet("mountpointStatus")]
        public IActionResult GetMountpointStatus([FromQuery] string Mountpoint)
        {
            MountpointSession? session = m_MountpointManager.GetMountpointSession(Mountpoint);
            
            if(session == null)
            {
                return NotFound($"Mountpoint '{Mountpoint}' not found.");
            }

            if (!session.m_Streamer.IsStreamActive)
            {
                return BadRequest($"Stream for mountpoint '{Mountpoint}' is not active.");
            }

            if (session.m_Streamer.m_Buffer.TryGetStatusSnapshot(out var _status))
            {
                var status = new List<MountpointStatusDTO>();

                foreach (var kvp in _status)
                {
                    var name = kvp.Key;
                    var info = kvp.Value;

                    status.Add(new MountpointStatusDTO
                    {
                        m_MessageType = name,
                        m_UtcTimeStamp = info.m_TimeStamp.ToString("yyyy-MM-dd HH:mm:ss zzz"),
                        m_LocalTimeStamp = info.m_TimeStamp.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss zzz"),
                        m_TimeInterval = info.m_TimeInterval.TotalSeconds
                    });
                }
                return Ok(new { status = status });
            }

            return StatusCode(500, "Failed to retrieve mountpoint status snapshot.");
        }

        [HttpGet("clientList")]
        public IActionResult GetClients()
        {
            List<SessionInfo> sessionInfo = m_ClientManager.GetSessionInfo();

            return Ok(new { sessionInfo = sessionInfo });
        }
    }
}
