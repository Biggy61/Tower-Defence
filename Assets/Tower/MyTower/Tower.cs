using UnityEngine;

namespace Tower
{
    public class Tower : MonoBehaviour
    {
        public int hp;
        public int maxHealth = 100;
        public HealthBar healthBar;
        void Start()
        {
            healthBar.SetMaxHealth(maxHealth);
        }
    
        void Update()
        {
            healthBar.SetHealth(hp);
        }
    }
}
