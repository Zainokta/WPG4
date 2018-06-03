using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdScript : MonoBehaviour {
    InterstitialAd interstitial;

    // Use this for initialization
    void Start()
    {
        //Request Ads
        RequestBanner();
        RequestInterstitial();
    }

    public void showInterstitialAd()
    {
        //Show Ad
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }
    }

    private void RequestBanner()
    {
#if UNITY_EDITOR
        string adUnitId = "unused";
#elif UNITY_ANDROID
			string adUnitId = "ca-app-pub-2656116996868766/6163595700";
#elif UNITY_IPHONE
			string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
#else
			string adUnitId = "unexpected_platform";
#endif

        BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
    }

    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-2656116996868766/1440277284";
#elif UNITY_IPHONE
			string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
#else
			string adUnitId = "unexpected_platform";
#endif
        
        interstitial = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        interstitial.LoadAd(request);
    }

}
