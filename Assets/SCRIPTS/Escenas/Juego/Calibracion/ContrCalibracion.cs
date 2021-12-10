using UnityEngine;
using UnityEngine.SceneManagement;

public class ContrCalibracion : MonoBehaviour
{
	public float TiempEspCalib = 3;
	float Tempo2 = 0;
	
	public enum Estados{Calibrando, Tutorial, Finalizado}
	public Estados EstAct = Estados.Calibrando;
	
	public ManejoPallets Partida;
	public ManejoPallets Llegada;
	public Pallet P;
    public ManejoPallets palletsMover;
	
	GameManager GM;
	
	//----------------------------------------------------//
	
	// Use this for initialization
	void Start () 
	{
        palletsMover.enabled = false;
		
		GM = GameObject.Find("GameMgr").GetComponent<GameManager>();
		
		P.CintaReceptora = Llegada.gameObject;
		Partida.Recibir(P);
		
		SetActivComp(false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(EstAct == ContrCalibracion.Estados.Tutorial)
		{
			if(Tempo2 < TiempEspCalib)
			{
				Tempo2 += Time.deltaTime;
				if(Tempo2 > TiempEspCalib)
				{
					 SetActivComp(true);
				}
			}
		}
	}
	
	public void IniciarTesteo()
	{
		EstAct = ContrCalibracion.Estados.Tutorial;
        palletsMover.enabled = true;
    }
	
	public void FinTutorial()
	{
		EstAct = ContrCalibracion.Estados.Finalizado;
		SceneManager.LoadScene("conduccion9");
        //palletsMover.enabled = false;
        //GM.FinCalibracion(Pj.IdPlayer);
	}
	
	void SetActivComp(bool estado)
	{
		if(Partida.GetComponent<Renderer>() != null)
			Partida.GetComponent<Renderer>().enabled = estado;
		Partida.GetComponent<Collider>().enabled = estado;
		if(Llegada.GetComponent<Renderer>() != null)
			Llegada.GetComponent<Renderer>().enabled = estado;
		Llegada.GetComponent<Collider>().enabled = estado;
		P.GetComponent<Renderer>().enabled = estado;
	}
}
