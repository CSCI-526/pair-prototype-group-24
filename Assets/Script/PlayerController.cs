using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Define gravity direction enum
    public enum GravityDirection { Up, Down, Left, Right }
    public GravityDirection currentGravity = GravityDirection.Down;

    [Header("Component References")]
    public Rigidbody2D playerRigidbody;

    [Header("Movement Parameters")]
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    // Ground check parameters
    [Header("Ground Check Settings")]
    // A child transform positioned at the player's feet (assign in Inspector)
    public Transform groundCheck;
    // Radius of the ground check circle
    public float groundCheckRadius = 0.1f;
    // Layer mask to specify which layers count as ground
    public LayerMask groundLayer;
    // Whether the player is grounded
    private bool isGrounded;

    // Whether gravity shifting is allowed; default is allowed
    private bool canShiftGravity = true;

    void Start()
    {
        if (playerRigidbody == null)
            playerRigidbody = GetComponent<Rigidbody2D>();

        // Initial gravity direction is Down
        currentGravity = GravityDirection.Down;
        UpdateGravity();
    }

    void Update()
    {
        // Ground check: update isGrounded status
        if (groundCheck != null)
        {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        }

        // If gravity shifting is not allowed and the current gravity direction is not Down, force it to Down
        if (!canShiftGravity && currentGravity != GravityDirection.Down)
        {
            currentGravity = GravityDirection.Down;
            UpdateGravity();
        }

        HandleGravitySwitch();
        HandleMovement();
    }

    /// <summary>
    /// Set whether gravity shifting is allowed
    /// </summary>
    public void SetGravityShift(bool canShift)
    {
        canShiftGravity = canShift;
        if (!canShift)
        {
            // When shifting is disabled, force the gravity direction to Down
            if (currentGravity != GravityDirection.Down)
            {
                currentGravity = GravityDirection.Down;
                UpdateGravity();
            }
        }
    }

    /// <summary>
    /// Switch gravity direction using arrow keys (effective only when allowed)
    /// </summary>
    void HandleGravitySwitch()
    {
        if (!canShiftGravity)
            return;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentGravity = GravityDirection.Up;
            UpdateGravity();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentGravity = GravityDirection.Down;
            UpdateGravity();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentGravity = GravityDirection.Left;
            UpdateGravity();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentGravity = GravityDirection.Right;
            UpdateGravity();
        }
    }

    /// <summary>
    /// Update global gravity and character rotation (rotation is only for visual effect) based on the current gravity direction
    /// </summary>
    void UpdateGravity()
    {
        switch (currentGravity)
        {
            case GravityDirection.Up:
                Physics2D.gravity = new Vector2(0, 9.81f);
                break;
            case GravityDirection.Down:
                Physics2D.gravity = new Vector2(0, -9.81f);
                break;
            case GravityDirection.Left:
                Physics2D.gravity = new Vector2(-9.81f, 0);
                break;
            case GravityDirection.Right:
                Physics2D.gravity = new Vector2(9.81f, 0);
                break;
        }

        // Update character rotation: Left is -90°, Right is 90°
        transform.rotation = Quaternion.Euler(0, 0, GetRotationAngle(currentGravity));
    }

    float GetRotationAngle(GravityDirection gd)
    {
        switch (gd)
        {
            case GravityDirection.Up:    return 180f;
            case GravityDirection.Down:  return 0f;
            case GravityDirection.Left:  return -90f;
            case GravityDirection.Right: return 90f;
            default: return 0f;
        }
    }

    void HandleMovement()
    {
        Vector2 input = Vector2.zero;
        if (Input.GetKey(KeyCode.A))
            input.x = -1;
        else if (Input.GetKey(KeyCode.D))
            input.x = 1;

        Vector2 moveDir = MapInputToWorld(input);
        Vector2 velocity = playerRigidbody.linearVelocity;
        Vector2 gravityAxis = GetGravityAxis();
        Vector2 preservedVelocity = Vector2.Dot(velocity, gravityAxis) * gravityAxis;
        Vector2 newVelocity = moveDir * moveSpeed + preservedVelocity;
        playerRigidbody.linearVelocity = newVelocity;

        // Jump only if grounded
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            Jump();
    }

    Vector2 MapInputToWorld(Vector2 input)
    {
        switch (currentGravity)
        {
            case GravityDirection.Left:
                return new Vector2(0, -input.x);
            case GravityDirection.Right:
                return new Vector2(0, input.x);
            case GravityDirection.Up:
                return new Vector2(input.x, 0);
            case GravityDirection.Down:
                return new Vector2(input.x, 0);
            default:
                return input;
        }
    }

    Vector2 GetGravityAxis()
    {
        switch (currentGravity)
        {
            case GravityDirection.Up:    return Vector2.up;
            case GravityDirection.Down:  return Vector2.down;
            case GravityDirection.Left:  return Vector2.left;
            case GravityDirection.Right: return Vector2.right;
            default: return Vector2.down;
        }
    }

    void Jump()
    {
        Vector2 jumpDir = -GetGravityAxis();
        playerRigidbody.AddForce(jumpDir * jumpForce, ForceMode2D.Impulse);
    }
}
