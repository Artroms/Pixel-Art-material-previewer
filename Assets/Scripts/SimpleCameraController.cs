using UnityEngine.EventSystems;

using UnityEngine;

    public class SimpleCameraController : MonoBehaviour, IDragHandler
    {
        private float modifier = 0.5f;
        public Transform rotated;

        public void OnDrag(PointerEventData data)
        {
            rotated.Rotate(Vector3.up, -data.delta.x * modifier, Space.World);
            rotated.Rotate(Vector3.right, data.delta.y * modifier, Space.Self);
        }

	public void SetSpeed(float speed)
	{
	    modifier = speed;
	}
    }