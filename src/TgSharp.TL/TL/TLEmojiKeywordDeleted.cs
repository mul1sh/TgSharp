using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TgSharp.TL;

namespace TgSharp.TL
{
    [TLObject(594408994)]
    public class TLEmojiKeywordDeleted : TLAbsEmojiKeyword
    {
        public override int Constructor
        {
            get
            {
                return 594408994;
            }
        }

        public string Keyword { get; set; }
        public TLVector<string> Emoticons { get; set; }

        public void ComputeFlags()
        {
            // do nothing
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Keyword = StringUtil.Deserialize(br);
            Emoticons = (TLVector<string>)ObjectUtils.DeserializeVector<string>(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Keyword, bw);
            ObjectUtils.SerializeObject(Emoticons, bw);
        }
    }
}
