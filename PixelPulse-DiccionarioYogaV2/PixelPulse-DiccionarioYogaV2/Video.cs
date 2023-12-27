using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PixelPulse_DiccionarioYogaV2
{
    internal class Video
    {
        private static Dictionary<string, string> videosYoutube = new Dictionary<string, string>
    {
        {"Tadasana", "https://www.youtube.com/embed/K0YpVejOGrg?si=XVVhEfl1udHdbUom"},
        {"Adho Mukha Svanasana", "https://www.youtube.com/embed/KkT3DEpCWe4?si=7B8SG_m3MfYhb98M"},
        {"Virabhadrasana I","https://www.youtube.com/embed/NgCY67xHwMI?si=ZYvjezY3MjfTXu74"},
        {"Virabhadrasana II","https://www.youtube.com/embed/-8hKpr5dxFM?si=P-feSGBtracYGIaX"},
        {"Vrikshasana","https://www.youtube.com/embed/6g5zC1B2EDQ?si=RRBAc2wieRjBaINl"},
        {"Balasana","https://www.youtube.com/embed/cFcNQjKDI58?si=1OwNRW06VyHKJpKN"},
        {"Ardha Bhujangasana","https://www.youtube.com/embed/YiaUHv5o5ls?si=Ahre5qLXj1Xx9DM2"},
        {"Paschimottanasana","https://www.youtube.com/embed/wG0eR6W1Jxg?si=DxM2vyg2rW6UBPSy" },
        {"Setu Bandhasana","https://www.youtube.com/embed/Hgca0II_CKI?si=gTIKPt69NrerYKX1"},
        {"Shavasana","https://www.youtube.com/embed/R-DB4qF6Egk?si=CbPpvBqdps1KRpNY"},
        {"Trikonasana","https://www.youtube.com/embed/pKLjp-VWtuw?si=Dmzk1TnKMrSysOwQ"},
        {"Kumbhakasana","https://www.youtube.com/embed/OL1TFWREaMw?si=BV9K3rUUByI4kGgW"},
        {"Urdhva Mukha Svanasana","https://www.youtube.com/embed/L57v0Lq9EcM?si=YOiaDFuIRVwRG_41"},
        {"Matsyasana","https://www.youtube.com/embed/BAhOz-b_dEc?si=EoGwD5c9KS0cfjv1"},
        {"Utkatasana","https://www.youtube.com/embed/iAclKRoyOjU?si=NybYGufH0jTxyHrI"},
        {"Malasana","https://www.youtube.com/embed/ZhcTGjiZhDc?si=MNiccCEyFYr7Ibed"},
        {"Eka Pada Rajakapotasana","https://www.youtube.com/embed/625gxCZFh74?si=1J1DZN4m7UMAMXTn"  },
        {"Urdhva Hastasana","https://www.youtube.com/embed/QMVJp_Fop2g?si=2BfHzkAC3AVl1guy"},
        {"Parivrtta Trikonasana","https://www.youtube.com/embed/ioUcFTiBCcY?si=PmDFZEWD9v7lEFIl"},
        {"Parivrtta Janu Sirsasana","https://www.youtube.com/embed/QCP6TEuosVs?si=h4m-H99XPanWPlSH"}
       };
        internal static string GetVideo(string fraseAtraducir)
        {

            if (videosYoutube.TryGetValue(fraseAtraducir, out string videoURL))
                return videoURL;
            return null;    

        }
    }
}