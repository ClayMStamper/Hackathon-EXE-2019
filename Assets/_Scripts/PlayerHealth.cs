using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;

public class PlayerHealth : MonoBehaviour, ITakeDamage {

    [SerializeField]
    private PostProcessVolume pp;
    private Vignette blood;

    [SerializeField]
    private float healRate = 3;
    [SerializeField] 
    private float hitWindow = .5f;

    private float timeSinceHit;
    
    void Start() {
        blood = pp.profile.GetSetting<Vignette>();
    }

    void Update() {
        Heal();
        timeSinceHit += Time.deltaTime;
    }
    
    public void OnHit(float damage) {
        
        if (timeSinceHit < hitWindow)
            return;

        timeSinceHit = 0;
        blood.intensity.value += damage;

        if (blood.intensity.value >= .99f) {
            SceneManager.LoadScene(0);
        }
        
    }

    private void Heal() {
        if (blood.intensity > 0)
            blood.intensity.value -= Time.deltaTime * healRate / 100;
    }
    
}
