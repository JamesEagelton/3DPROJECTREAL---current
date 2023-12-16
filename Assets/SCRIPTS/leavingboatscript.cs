

using UnityEngine;
using UnityEngine.SceneManagement;



public class leavingboatscript : MonoBehaviour
{
    public string sceneName;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null) 
        {
           
            
                SceneManager.LoadScene(sceneName);
            
            
          
            
                   
                    
              

        }
    }
}
