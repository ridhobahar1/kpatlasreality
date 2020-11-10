using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustHouse : MonoBehaviour
{

    public Slider ScaleSlider;

    [SerializeField] float currentScale = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        ScaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(ScaleSlider.value, ScaleSlider.value, ScaleSlider.value);
    }

    private void OnGUI()
    {
        currentScale = GUI.HorizontalSlider(new Rect(-280f, 120.0f, 228.0f, 57.0f), currentScale, 0.0f, 2f);
        transform.localScale = new Vector3(currentScale, currentScale, currentScale);

    }

    public void AdjustScale(float newScale)
    {

    }
}
