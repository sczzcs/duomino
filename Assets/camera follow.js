#pragma strict
var cameras : GameObject;
var speed : float = 0.1;

function Update () {

if(Input.mousePosition.x>=Screen.width){
cameras.transform.position.x += speed;
}
if(Input.mousePosition.x<=0){
cameras.transform.position.x -= speed;
}
if(Input.mousePosition.y>=Screen.height){
cameras.transform.position.z += speed;
}
if(Input.mousePosition.y<=0){ 
cameras.transform.position.z -= speed;
}

}