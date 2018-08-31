using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computadora : MonoBehaviour {
    
     public int vida=10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
         if (Input.GetKeyDown(KeyCode.LeftArrow))
{
    Vector3 position = this.transform.position;
    position.x++;
    this.transform.position = position;
}
if (Input.GetKeyDown(KeyCode.RightArrow))
{
    Vector3 position = this.transform.position;
    position.x--;
    this.transform.position = position;
}
if (Input.GetKeyDown(KeyCode.UpArrow))
{
    Vector3 position = this.transform.position;
    position.z--;
    this.transform.position = position;
}
if (Input.GetKeyDown(KeyCode.DownArrow))
{
    Vector3 position = this.transform.position;
    position.z++;
    this.transform.position = position;
}
 if (Input.GetKeyDown(KeyCode.Space))
{
    GameObject go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
    go.GetComponent<Renderer>().material.color=this.GetComponent<Renderer>().material.color;
    go.transform.position = this.transform.position;
    go.transform.localScale = new Vector3(.5f, .5f, .5f);
    go.AddComponent<Rigidbody>();
    go.GetComponent<Collider>().isTrigger=true;
    go.GetComponent<Rigidbody>().useGravity=false;
    go.name= "BombaC";
    
}
        if(vida==0)
        {
            Destroy(this);
        }

		
	}
    private void OnTriggerEnter(Collider other)
{
    if(other.gameObject.name=="BombaP")
    {
        Destroy(other.gameObject);
        this.vida--;
    }
}
    void OnGUI()
{
    
    GUI.Label(new Rect(10,20,100,50),new
    GUIContent("P2: "+this.vida));
}
}

