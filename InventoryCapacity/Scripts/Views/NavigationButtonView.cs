using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace InventoryCapacity
{
    public class NavigationButtonView : MonoBehaviour
    {
        public event Action<NavigationButtonView> OnClicked;

        private Image _image;
        private Button _button;

        private bool _isSelected;
        private bool _isWarning;

        private void Awake()
        {
            _image = gameObject.AddComponent<Image>();
            _image.type = Image.Type.Sliced;

            _button = gameObject.AddComponent<Button>();
            _button.onClick.AddListener(() => OnClicked?.Invoke(this));
            _button.transition = Selectable.Transition.None;
            _button.navigation = new Navigation()
            {
                mode = Navigation.Mode.None
            };
        }

        public void SetParent(Transform parent)
        {
            transform.SetParent(parent, false);
        }

        public void PlayInteractionAnimation()
        {
            if (gameObject.activeInHierarchy == false) return;

            StopAnimation();
            StartCoroutine(AnimateInteraction());
        }

        public void StopAnimation()
        {
            _isWarning = false;
            StopAllCoroutines();
            UpdateSprite();
        }

        public void SetSelected(bool isSelected)
        {
            _isSelected = isSelected;
            UpdateSprite();
        }

        private void UpdateSprite()
        {
            _image.sprite = _isSelected ? Assets.InventoryPageButtonSelected : Assets.InventoryPageButtonNormal;
            if (_isWarning)
                _image.sprite = Assets.InventoryPageButtonWarning;
        }

        private void OnDisable()
        {
            StopAnimation();
        }

        private IEnumerator AnimateInteraction()
        {
            for (var i = 0; i < 5; i++)
            {
                _isWarning = true;
                UpdateSprite();
                yield return new WaitForSeconds(0.1f);

                _isWarning = false;
                UpdateSprite();
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
