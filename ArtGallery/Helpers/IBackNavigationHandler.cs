using System;

namespace ArtGallery.Helpers
{
    public interface IBackNavigationHandler
    {
        event EventHandler<bool> OnPageCanGoBackChanged;

        void GoBack();
    }
}
