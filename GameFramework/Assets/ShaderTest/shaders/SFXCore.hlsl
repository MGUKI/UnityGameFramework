#ifndef UNITY_SFXCORE_INCLUDED
#define UNITY_SFXCORE_INCLUDED
half DissolvSmooth(half dissolveTex,half SmoothClipInt,half SoftDissolveIndensity)
{
    dissolveTex += 1;
    dissolveTex += SoftDissolveIndensity*-2;
    dissolveTex = clamp(dissolveTex,0,1);
    dissolveTex = smoothstep(SmoothClipInt,1-SmoothClipInt,dissolveTex);//hard Clip
    return dissolveTex;
}

#endif