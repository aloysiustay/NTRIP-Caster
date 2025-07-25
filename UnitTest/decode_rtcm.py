import sys
import json
from pyrtcm import RTCMReader

input_file = sys.argv[1]
messages = []

with open(input_file, "rb") as f:
    reader = RTCMReader(f)
    for (_, msg) in reader:
        msg_str = str(msg)
        if msg_str.startswith("<RTCM"):
            msg_str = msg_str.lstrip("<RTCM(").rstrip(")>")
            fields = msg_str.split(", ")
            msg_dict = {}
            for field in fields:
                if "=" in field:
                    key, val = field.split("=")
                    try:
                        msg_dict[key.strip()] = eval(val.strip())
                    except:
                        msg_dict[key.strip()] = val.strip()
            messages.append(msg_dict)

print(json.dumps(messages))
