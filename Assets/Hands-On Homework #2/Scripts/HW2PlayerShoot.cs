using UnityEngine;

public class HW2PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public GameObject preFab2;
    public Transform bulletTrash;
    public Transform bulletShoot;

    private const float Timer = 0.5f;
    private float _currentTime = 0.5f;
    private bool _canShoot = true;

    private void Update()
    {
        TimerMethod();
        ShootMethod();
        ShootMethodS();
    }

    private void ShootMethod()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot)
        {
            GameObject bullet = Instantiate(preFab, bulletShoot.position, bulletShoot.rotation, bulletTrash);
            bullet.transform.SetParent(bulletTrash);
            _canShoot = false;
        }
    }

    private void ShootMethodS()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && _canShoot)
        {
            GameObject bulletS = Instantiate(preFab2, bulletShoot.position, bulletShoot.rotation, bulletTrash);
            bulletS.transform.SetParent(bulletTrash);
            _canShoot = false;
        }
    }

    private void TimerMethod()
    {
        if (!_canShoot)
        {
            _currentTime -= Time.deltaTime;
            if (_currentTime < 0)
            {
                _canShoot = true;
                _currentTime = Timer;
            }
        }
    }
}
