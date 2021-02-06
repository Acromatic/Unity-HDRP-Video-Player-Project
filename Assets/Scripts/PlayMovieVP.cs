using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

using DotNetTools.SharpGrabber;
using DotNetTools.SharpGrabber.Media;
using DotNetTools.SharpGrabber.Internal.Grabbers;

public class PlayMovieVP : MonoBehaviour
{
    public async void Start()
    {

        var grabber = new YouTubeGrabber();
        //var result = await grabber.GrabAsync(new Uri("https://www.youtube.com/watch?v=4r2thboZ_xY"));
        var result = await grabber.GrabAsync(new Uri("https://www.youtube.com/watch?v=1PuGuqpHQGo"));

        IList <IGrabbed> grabbedResources = result.Resources;
        
        /*
        foreach (var v in grabbedResources)
        {
           Debug.Log(v.ResourceUri.ToString()); 
        }*/

        //Create a Video Player on Scripts attached object via Material Override
        var vp = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();

        //Select a video to play
        //vp.url = "file://./Assets/Videos/test.mp4";
        //vp.url = "https://r2---sn-vgqskned.googlevideo.com/videoplayback?expire=1612613371&ei=mzIeYPmHKYfxNtG1h4gC&ip=47.224.66.188&id=o-ABrzK5AoryngH-XRhB-r100CqRFLA8CnrZkdw0xpa3Xh&itag=22&source=youtube&requiressl=yes&mh=cu&mm=31%2C29&mn=sn-vgqskned%2Csn-vgqsrne6&ms=au%2Crdu&mv=m&mvi=2&pl=17&initcwndbps=1871250&vprv=1&mime=video%2Fmp4&ns=nwMiU8kF_kN6tU5wuJOwQV4F&cnr=14&ratebypass=yes&dur=39.473&lmt=1545310565348051&mt=1612591481&fvip=2&c=WEB&txp=5432432&n=uXL2NkDy85z12oG&sparams=expire%2Cei%2Cip%2Cid%2Citag%2Csource%2Crequiressl%2Cvprv%2Cmime%2Cns%2Ccnr%2Cratebypass%2Cdur%2Clmt&sig=AOq0QJ8wRQIhAPSEdFrC-e6KUNhET9LVM8GCOCqmUVzSHusWueWICb5nAiA3C3Q9mAkGaiN6aiFHBnd6V2UjTC5YlW2EZ_gEGqb4ig%3D%3D&lsparams=mh%2Cmm%2Cmn%2Cms%2Cmv%2Cmvi%2Cpl%2Cinitcwndbps&lsig=AG3C_xAwRAIgZMmHsulQHbjMAVzPyNlxdsZo25SeczG-kTQal3x9fHQCIG6prnOWvu-Qi4sUBoBuYlYXIvzQTx_Ysuc_qFkPxQQa";
        //vp.url = "https://r1---sn-vgqs7nlk.googlevideo.com/videoplayback?expire=1612629464&ei=eHEeYICNLoGRiwTfxb6YCQ&ip=47.224.66.188&id=o-AInQF210V2RKyTg2vgLjvlkz6kTAx9t2rrmIHAdBWSZu&itag=22&source=youtube&requiressl=yes&mh=vG&mm=31%2C29&mn=sn-vgqs7nlk%2Csn-vgqsknek&ms=au%2Crdu&mv=m&mvi=1&pl=17&initcwndbps=2127500&vprv=1&mime=video%2Fmp4&ns=MoTw5TjV3sQlq8OYusmLzqUF&cnr=14&ratebypass=yes&dur=622.991&lmt=1606402705989906&mt=1612607562&fvip=1&c=WEB&txp=6211222&n=O8afbkEq3PXReQ9&sparams=expire%2Cei%2Cip%2Cid%2Citag%2Csource%2Crequiressl%2Cvprv%2Cmime%2Cns%2Ccnr%2Cratebypass%2Cdur%2Clmt&sig=AOq0QJ8wRgIhAOk-6sMxS_m8oajsdERI4AVqcTiTCtM17ZcpLk4q2CwCAiEA27xdqPc41UzNitbgIBu1BUTr93tIvGmn8-WoFyQb2KI%3D&lsparams=mh%2Cmm%2Cmn%2Cms%2Cmv%2Cmvi%2Cpl%2Cinitcwndbps&lsig=AG3C_xAwRQIgHVl7O67K6reT__Lka_MBW-UaaBU8BMIYudYbSiL_7A4CIQDRkG5-vw-vVXBdcjAI8pXwyjz-_o7Ewkjob6PeQCnZ0A%3D%3D";
        //vp.url = myUrl.ToString();
        vp.url = grabbedResources[6].ResourceUri.ToString();
        
        vp.isLooping = false;
        vp.renderMode = UnityEngine.Video.VideoRenderMode.MaterialOverride;
        vp.targetMaterialRenderer = GetComponent<Renderer>();
        vp.targetMaterialProperty = "_BaseColorMap";

        vp.Play();
    }
}