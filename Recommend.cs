using UnityEngine;
using System.Linq;
using System.Collections;
using UnityEngine.UI;

public class Recommend : MonoBehaviour {

	public Text t;	  

	public void onClick(){
		{
			//string[] db = new string[] { "CPRU", "HUZY" };
			string[] db=new string[]{"CPRU","HUZY","SPZYR","BDPR","LDEPZY","AEY","SPZY","OUR","HZR","HPUR"};
			//"LPUZ","LEU","FEZR","CPR","AEZY","AEZY","LPUZ","SPZR","CDUR","OEUY","HUZR","BUR","OUZ","HDZY","HDZYR","LDU","HDZR","BDU","SDPZYR","HDZ","SDZY","FDZR","LDP","FZR","FDZR","ODR","SPUZ","LDPUZ","SDPZY","OUZ","OPY","BZY","CUR","HZRD","CPU","FCZ","OPU","LDPR","OPZ","ODUY","ODY","AEZ","AEZ","AEZY","OEU","BDPU","AEZ"};
			//string[] places=new string[]{"Attend Concerts at Music academy","Try death by chocolate at Chocolate factory"};
			string[] places=new string[]{"Attend Concerts at Music academy","Try death by chocolate at Chocolate factory","Attend Service at Santhome Church","Watch a movie at Prarthana Beach Drive-in theatre","Long drive down ECR road","Go to the top of a lighthouse","Attend Evening lectures at Iskon Temple","Travel in the anna durai auto","Have samosas at the Samosa Factory","Eat a crispy molaga bajji at Marina Beach"};
			//"Observe wildlife at vandaloor zoo","Look at crocodiles at the crocodile bank","go shopping at Chennai city centre","Pay your respects at Anna Square","DO SOMETHING at off road sports","Visit mayajaal for a dose of adventure","have a calm morning bird watching at vandathakil lake bird sanctuary","Visit the basant nagar church","Enjoy the fragrances of the Koyembedu flower market","Sail like a king atop a catamaran","Enjoy paneer dosa at Saravan Bhavan","Go to the annual chennai book fair","Experience rajasthan at choki dhani","Unique flavoured ice cream at Ecstacy","Discover human history at Egmore Museum","Have biryani at Charminar Biryani Centre","Visit anna centennary library","Pray to lord Krishna at Puri Jagannath temple","Drink Panner Soda","Visit the Vadapalani Murugan temple","Experience the chaos that is Chennai at Ranganathan street","experience mahashivratri at Tada Falls","Gettrendy souveniers at Island grounds fair","Buy handicrafts at Pondy Bazaar","A rickshaw ride in the city of Chennai","Explore the beautiful gardens of the Theosophical Society","Virtual tour of the night sky at Birla Planitarium","Service at Saint Thomas Mount church","Killi jyosium at Marina Beach","Enjoy the view of Broken Bridge","Watch a movie at Satyam Cinema","Imagine living like royalty at Chettinad Palace","Idly and sambar from Rathna cafe","Look at the descent of the ganges at Mahabalipuram","try chilli's at Express avenue","The amazing view at thalamkuppam pier","Savour seafood at Elliot beach","Participate in turtle walk on chennai beach","Buy a souveneir from old curiosity shop","Listen to RJ Balaji","Flying kites at Marina beach","Go Go-Kart","Go bowling at down under","Visit the haunted De Monte Colony","Browse the infamous Alwar bookstore","go Scuba Diving"};
			//string[] db = new string[]{"PUOQ","PSRU"};
			string input="PQR";
			//		int c=0;`
			int m,i;
			int z = 0;
			//List<int> v= new List<int>();
			int [] v=new int[10] ;
			Debug.Log (input.Length);
			for (i = 0; i < db.Length; i++)  		//iterates places(strings)
			{	
				v [i] = 0;

				for (int j = 1; j < input.Length; j++) 
				{

					for (int k = 1; k < input.Length; k++){
						if (input [k] == db [i] [j]) {
							v [i]++;
							break;
						}
					}

					//iterates characters(emotions) of string(place)p
				}
			}	
			m = v.Max();
			for (i = 0; i < v.Length; i++)
			{
				if (v [i] == m) {
					z = i;
				}


				//place with highest number of emotion-matches, remaining within the 
				//same theme, is output
			}

			string output = places[z];

			t.text = output;


		}
	}
}