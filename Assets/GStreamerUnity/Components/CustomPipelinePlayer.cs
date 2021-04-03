using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

[RequireComponent(typeof(GstCustomTexture))]
public class CustomPipelinePlayer : MonoBehaviour {
	GstCustomTexture m_Texture;

	public Texture2D BlittedImage;

	public Material TargetMaterial;

	public string pipeline = "";
	public string port = "";

	public Rect BlitRect=new Rect(0,0,1,1);
	GstImageInfo _img;

	public long position;
	public long duration;
	bool _newFrame=false;
	// Use this for initialization

	void Start () {
		GameObject parent = GameObject.Find("CameraManager");;
		for(int i = 0; i< parent.transform.childCount; i++){
			if(this.gameObject.name == ("VideoStream"+(i+1) ) ){
				port = this.GetComponentInParent<CameraManager>().GetPorts()[i];
			}

		}

		m_Texture = gameObject.GetComponent<GstCustomTexture>();
		m_Texture.Initialize ();
        //StartCoroutine(Dalay());
		System.Threading.Thread.Sleep(100);
		//pipeline = "udpsrc port="+port+" ! application/x-rtp,encoding-name=H264,payload=96 ! rtph264depay ! h264parse ! avdec_h264 ! videoconvert ! appsink name=videoSink";
		pipeline = "udpsrc port="+port+" ! application/x-rtp ! rtph264depay ! avdec_h264 ! videoconvert ! appsink name=videoSink";
		m_Texture.SetPipeline(pipeline);  // 		pipeline+" ! video/x-raw,format=I420 ! videoconvert ! appsink name=videoSink"
        //StartCoroutine(Dalay());
		System.Threading.Thread.Sleep(100);
		m_Texture.Player.CreateStream();
        //StartCoroutine(Dalay());
		System.Threading.Thread.Sleep(100);
		m_Texture.Player.Play ();
	
		m_Texture.OnFrameBlitted += OnFrameBlitted;
		_img = new GstImageInfo ();
		_img.Create (1, 1, GstImageInfo.EPixelFormat.EPixel_R8G8B8);

		BlittedImage = new Texture2D (1, 1);
		BlittedImage.filterMode = FilterMode.Bilinear;
		BlittedImage.anisoLevel=0;
		BlittedImage.wrapMode=TextureWrapMode.Clamp;

		if(TargetMaterial!=null)
			TargetMaterial.mainTexture=BlittedImage;
	}
	 IEnumerator Dalay()
    {
		        yield return new WaitForSeconds(3);
    }
	void OnFrameBlitted(GstBaseTexture src,int index)
	{
		//m_Texture.Player.CopyFrame (_img);
		float w=m_Texture.Player.FrameSizeImage.x;
		float h=m_Texture.Player.FrameSizeImage.y;
		m_Texture.Player.CopyFrameCropped(_img,(int)(BlitRect.x*w),(int)(BlitRect.y*h),(int)(BlitRect.width*w),(int)(BlitRect.height*h));
		_newFrame = true;
		if (_newFrame) {
			_img.BlitToTexture (BlittedImage);
			_newFrame = false;
		}

//		Debug.Log(String.Format("Frame Copied {0}x{1}",_img.Width,_img.Height));
	}
	public void OnGUI()
	{
	}
	void OnDestroy()
	{
		if(_img!=null)
			_img.Destory ();
//		Debug.Log ("Destorying Image");
	}
	
	// Update is called once per frame
	void Update () {
		/*
		string selectedCamera = CameraManager.GetInstance().GetSelection();
		if(selectedCamera != actualCamera){
			Initialize(selectedCamera);
			Debug.Log ("New video...");

		}
		*/
	
		position=m_Texture.Player.GetPosition ()/1000;
		duration=m_Texture.Player.GetDuration ()/1000;
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			var p = (position - 5000) ;
			if (p < 0)
				p = 0;
			m_Texture.Player.Seek (p * 1000);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			var p = (position + 5000);
			if (p >=duration)
				p = duration;
			m_Texture.Player.Seek (p * 1000);
		}
		if (Input.GetKeyDown (KeyCode.S))
			m_Texture.Stop ();

		if (Input.GetKeyDown (KeyCode.P))
			m_Texture.Play ();
	}
	void  OnApplicationQuit()
	{
		Debug.Log("Cerrando instancia de cámara");
		m_Texture.Pause();
		m_Texture.Stop();
		m_Texture.Close();

	}
}
