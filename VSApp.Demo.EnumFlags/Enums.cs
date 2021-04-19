using System;
using System.Collections.Generic;
using System.Text;

namespace VSApp.Demo.EnumFlags
{
    [Flags]
    public enum MediaType { RealisticPicture = 1, DrawedPicture = 2 , Audio = 4, Music = 8, DocumentaryVideo= 5, AnimeVideo = 6, MusicalClip = 11   }
}
