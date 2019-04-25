using System.Collections.Generic;
using Enklu.Data;
using Enklu.Mamba.Network;

namespace Enklu.Mamba.Kinect
{
    public class Util
    {
        public static ElementData CreateElementData(string name)
        {
            return new ElementData
            {
                Schema = new ElementSchemaData
                {
                    Strings = new Dictionary<string, string>
                    {
                        { "name", name }
                    }
                }
            };
        }

        public static ElementData CreateElementData(string name, string asset)
        {
            var elm = CreateElementData(name);
            elm.Schema.Strings["assetSrc"] = asset;
            elm.Type = ElementTypes.ASSET;
            return elm;
        }
    }
}