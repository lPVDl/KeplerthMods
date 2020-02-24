using Keplerth;
using UnityEngine;
using UnityEngine.UI;

namespace BrokenItems
{
    public static class ItemColorUtil
    {
        private static Material _imageNormal;
        private static Material _imageRed;

        private static Material _spriteNormal;
        private static Material _spriteRed;

        public static void ModifyColor(Image image, ItemData item)
        {
            if (image == null) return;

            if (_imageNormal == null)
            {
                _imageNormal = new Material(image.material);
                _imageRed = new Material(_imageNormal);
                _imageRed.color = Color.red;
            }

            image.material = item.curDurability > 0 || item.maxDurability <= 1 ? _imageNormal : _imageRed;
        }

        public static void ModifyColor(SpriteRenderer spriteRenderer, ItemData item)
        {
            if (spriteRenderer == null) return;

            if (_spriteNormal == null)
            {
                _spriteNormal = new Material(spriteRenderer.material);
                _spriteRed = new Material(_spriteNormal);
                _spriteRed.color = Color.red;
            }

            spriteRenderer.material = item.curDurability > 0 || item.maxDurability <= 1 ? _spriteNormal : _spriteRed;
        }
    }
}
