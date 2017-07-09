using Net.Chdk.Meta.Model.Camera.Eos;
using Net.Chdk.Meta.Writers.Camera.Json;
using System.Collections.Generic;

namespace Net.Chdk.Meta.Writers.Camera.Eos.Json
{
    sealed class JsonEosCameraWriter : JsonCameraWriter, IEosCameraWriter
    {
        public void WriteCameras(string path, IDictionary<string, EosCameraData> cameras)
        {
            WriteJson(path, cameras);
        }
    }
}
