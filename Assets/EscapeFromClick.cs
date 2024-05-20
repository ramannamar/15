using UnityEngine;
using UnityEngine.SceneManagement;


public class EscapeFromClick : MonoBehaviour
{
    [SerializeField]
    public Color color;
    private Renderer objRenderer;
    
    private bool isMouseOver = false;

    public void Start()
    {
        objRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (isMouseOver)
        {
            transform.Translate(new Vector3(Random.Range(-0.05f, 0.05f), 0f, Random.Range(-0.05f, 0.05f)), Space.World);         
        }
    }

    private void FixedUpdate()
    {
        if (objRenderer == null)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void OnMouseEnter()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }
        
    private void OnMouseOver()
    {
        if (true)        
        {
            objRenderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));    
            
        }
    }

    private void OnMouseDown()
    {
        Destroy(objRenderer);
    }
}
