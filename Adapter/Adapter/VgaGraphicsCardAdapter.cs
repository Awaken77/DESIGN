using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class VgaGraphicsCardAdapter
    {
        private VgaGraphicsCard _vgaGraphicsCard;

        public VgaGraphicsCardAdapter (VgaGraphicsCard vgaGraphicsCard)
        {
            _vgaGraphicsCard = vgaGraphicsCard;
        }

        public DviStream GetDviStream()
        {
            byte[] data = _vgaGraphicsCard.GetVgaStream().GetData();

            byte[] dviVideoData = ConvertFromVgaToDvi(data);
            DviStream dviStream = new DviStream();
            dviStream.SetData(dviVideoData);
            return dviStream;
        }

        private byte[] ConvertFromVgaToDvi(byte[]input)
        {
            Console.WriteLine("Converted VGA Video to DVI video");
            return new byte[] { };
        }

    }
}
