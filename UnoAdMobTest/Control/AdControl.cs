#if ANDROID
using Android.Gms.Ads;
using Android.Widget;
#endif
using System.Collections.Generic;
using Microsoft.UI.Xaml.Controls;

namespace UnoAdMobTest.Control;

public partial class AdControl : ContentControl
{
    public AdControl()
    {
#if ANDROID
        var adView = new AdView(ContextHelper.Current);
        adView.AdSize = AdSize.SmartBanner;
        adView.AdUnitId = "ca-app-pub-3940256099942544/6300978111";
        HorizontalContentAlignment = HorizontalAlignment.Stretch;
        VerticalContentAlignment = VerticalAlignment.Stretch;
        var adParams = new LinearLayout.LayoutParams(
            LayoutParams.WrapContent, LayoutParams.WrapContent);
        adView.LayoutParameters = adParams;
        adView.LoadAd(new AdRequest.Builder().Build());
        Content = adView;
#endif
    }
}


