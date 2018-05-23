using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SimpleBlit : MonoBehaviour
{

    public Material transMaterial;

    private float cutoff = 0.0f;

    public AnimationCurve curve;

    public float realCutoff;

    public float speedMultiplier;

    private float curveTime = 0f;

    float curveAmount;

    void OnRenderImage(RenderTexture src, RenderTexture dst)
    {
        if (transMaterial != null)
            Graphics.Blit(src, dst, transMaterial);
    }

    private void Start()
    {
        transMaterial.SetFloat("_Cutoff", cutoff);
    }
    public IEnumerator startTransition()
    {
        curveTime += speedMultiplier * Time.deltaTime;
        curveAmount = curve.Evaluate(curveTime);

        cutoff = realCutoff + curveAmount;

        transMaterial.SetFloat("_Cutoff", cutoff);

        yield return new WaitForSeconds(1f);
    }
   
}