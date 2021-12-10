using System.Threading.Tasks;
using UnityEngine;

public class Cannon : MonoBehaviour {
    public GameObject bulletPrefab;
    public float speed = 20f;

    private void Start() {
        Shoot();
    }
    
    async void Shoot() {
        await Task.Delay(2000);
        GameObject bullet = Instantiate(this.bulletPrefab);
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();

        bulletRb.transform.position = this.transform.position;
        
        bulletRb.velocity = Vector3.left * this.speed;
        
        Shoot();
        await Task.Delay(2500);
        Destroy(bullet);
    }
}
