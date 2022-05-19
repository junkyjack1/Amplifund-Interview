using System.Collections.Generic;
using System.Linq;
using TMakesCode.Amplifund.Domain;

namespace TMakesCode.Amplifund.Data.Listings
{
    public class DescriptionListing
    {
        public static List<Description> Descriptions { get; }

        static DescriptionListing()
        {
            var fredReviewsFredsCar = new Description()
            {
                PersonaId = PersonaListing.Fred.Id,
                CarId = CarListing.Canopysaurus.Id,
                Text = "Whaddya, know? That looks kind like The Flintmobile. Wait are those marble seats?"
            };

            var fredReviewsGeorgesCar = new Description()
            {
                PersonaId = PersonaListing.Fred.Id,
                CarId = CarListing.FxAtmos.Id,
                Text = "Can you breathe in that? Somethings fishy about that car right there; I don't like it. Looks like a fish bowl."
            };

            var fredReviewsLightningMcQueen = new Description()
            {
                PersonaId = PersonaListing.Fred.Id,
                CarId = CarListing.LightningMcQueen.Id,
                Text = "They said in the future cars would drive themselves, but I didn't expect this."
            };

            var fredReviewsMargesCar = new Description()
            {
                PersonaId = PersonaListing.Fred.Id,
                CarId = CarListing.ChevelleWagon.Id,
                Text = "Now that's what I call I marvel of modern engineering!"
            };

            var georgeReviewsFredsCar = new Description()
            {
                PersonaId = PersonaListing.George.Id,
                CarId = CarListing.Canopysaurus.Id,
                Text = "Pssh. Something out of the stone age."
            };

            var georgeReviewsGeorgesCar = new Description()
            {
                PersonaId = PersonaListing.George.Id,
                CarId = CarListing.FxAtmos.Id,
                Text = "It's not the newest model out, but it sure is relieable."
            };

            var georgeReviewsLightningMcQueen = new Description()
            {
                PersonaId = PersonaListing.George.Id,
                CarId = CarListing.LightningMcQueen.Id,
                Text = "Talking cars! I remember my grandfather telling me about those. Boy does that take me back."
            };

            var georgeReviewsMargesCar = new Description()
            {
                PersonaId = PersonaListing.George.Id,
                CarId = CarListing.ChevelleWagon.Id,
                Text = "It doesn't fly, but I have to admit it seems pretty functional."
            };

            var lightningReviewsFredsCar = new Description()
            {
                PersonaId = PersonaListing.Lightning.Id,
                CarId = CarListing.Canopysaurus.Id,
                Text = "This is a joke right?"
            };

            var lightningReviewsGeorgesCar = new Description()
            {
                PersonaId = PersonaListing.Lightning.Id,
                CarId = CarListing.FxAtmos.Id,
                Text = "Is it really a car if it flies? I'm just saying, I don't think this should even be here."
            };

            var lightningReviewsLightningMcQueen = new Description()
            {
                PersonaId = PersonaListing.Lightning.Id,
                CarId = CarListing.LightningMcQueen.Id,
                Text = "Oh? Hey there good looking -- Ka-chow!"
            };

            var lightningReviewsMargesCar = new Description()
            {
                PersonaId = PersonaListing.Lightning.Id,
                CarId = CarListing.ChevelleWagon.Id,
                Text = "Impressive! Still getting around at that age."
            };

            var margeReviewsFredsCar = new Description()
            {
                PersonaId = PersonaListing.Marge.Id,
                CarId = CarListing.Canopysaurus.Id,
                Text = "Mmmm..."
            };

            var margeReviewsGeorgesCar = new Description()
            {
                PersonaId = PersonaListing.Marge.Id,
                CarId = CarListing.FxAtmos.Id,
                Text = "Flying is neat and all, but I don't think it's very pratical."
            };

            var margeReviewsLightningMcQueen = new Description()
            {
                PersonaId = PersonaListing.Marge.Id,
                CarId = CarListing.LightningMcQueen.Id,
                Text = "He looks awfully fast."
            };

            var margeReviewsMargesCar = new Description()
            {
                PersonaId = PersonaListing.Marge.Id,
                CarId = CarListing.ChevelleWagon.Id,
                Text = "It's not the fanciest, but it's mine and I like it."
            };

            Descriptions = new List<Description>
            {
                fredReviewsFredsCar,
                fredReviewsGeorgesCar,
                fredReviewsLightningMcQueen,
                fredReviewsMargesCar,
                georgeReviewsFredsCar,
                georgeReviewsGeorgesCar,
                georgeReviewsLightningMcQueen,
                georgeReviewsMargesCar,
                lightningReviewsFredsCar,
                lightningReviewsGeorgesCar,
                lightningReviewsLightningMcQueen,
                lightningReviewsMargesCar,
                margeReviewsFredsCar,
                margeReviewsGeorgesCar,
                margeReviewsLightningMcQueen,
                margeReviewsMargesCar,
            };
        }
        
        public static List<Description> ToList()
        {
            return Descriptions;
        }
    }
}
