using Assets.Ball_Blast.Scripts;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private HingeJoint2D[] _wheels;
    [SerializeField] private float _cannonSpeed;
    [SerializeField] private float _angular—oefficient;

    private RealizationAdministration _realizationAdministration;
    private Camera _cam;
    private Rigidbody2D _rb;

    private JointMotor2D _jointMotor;
    private Vector2 _pos;

    private bool _isMoving = true;

    private void Start()
    {
        _cam = Camera.main;

        _rb = GetComponent<Rigidbody2D>();
        _pos = _rb.position;

        _jointMotor = _wheels[0].motor;
    }

    private void Update()
    {
        _isMoving = Input.GetMouseButton(0);

        if (_isMoving)
            _pos.x = _cam.ScreenToWorldPoint(Input.mousePosition).x;
    }

    private void FixedUpdate()
    {
        ObtainingManagementValues();
        CheckRotation();
    }
    private void CheckRotation()
    {
        if (_jointMotor.motorSpeed > 0.0f)
        {
            ActiveMotor(true);
        }
        else
        {
            ActiveMotor(false);
        }

    }

    private void ObtainingManagementValues()
    {
        _realizationAdministration = new RealizationAdministration(_cannonSpeed, _rb, _pos, _isMoving);
        _realizationAdministration.Movement();
        _jointMotor.motorSpeed = _realizationAdministration.Rotation();
    }

    private void ActiveMotor(bool isActive)
    {
        _wheels[0].useMotor = isActive;
        _wheels[1].useMotor = isActive;

        _wheels[0].motor = _jointMotor;
        _wheels[1].motor = _jointMotor;
        Debug.Log("Start rotate " + isActive + " " + _jointMotor);
    }
}
