// Check if there is no input from the player and the character is grounded
if (input.magnitude == 0 && isGrounded)
{
    // Disable gravity
    Rigidbody characterRigidbody = GetComponent<Rigidbody>();
    characterRigidbody.useGravity = false;
}
else
{
    // Enable gravity
    Rigidbody characterRigidbody = GetComponent<Rigidbody>();
    characterRigidbody.useGravity = true;
}
