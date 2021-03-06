using RectangleTrainer.Compass.UI;
using UnityEditor;
using UnityEngine;

namespace RectangleTrainer.Compass.World
{
    public class Trackable : MonoBehaviour
    {
        [SerializeField] private ATrackableIcon icon;
        [SerializeField] private bool iconPersistent = false;

        public bool Focused = false;
        public bool IconPersistent => Focused || iconPersistent;

        public Vector3 Position => transform.position;
        public ATrackableIcon Icon => icon;

        protected virtual void Start() {
            Tracker.AddTrackable(this);
        }

        public void SetIconPF(ATrackableIcon icon) {
            this.icon = icon;
        }

        protected virtual void OnEnable() {
            //TODO: Tracker Show Icon
        }

        protected virtual void OnDisable() {
            //TODO: Tracker Hide Icon
        }

        protected virtual void OnDestroy() {
            Tracker.RemoveTrackable(this);
        }
    }
}