using Fish.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fish.ViewModels
{
    public class OnboardingViewModel : BaseViewModel
    {

        private ObservableRangeCollection<OnboardingModel> items; //collection of Items
        public ObservableRangeCollection<OnboardingModel> Items { get => items;
            set => SetProperty(ref items, value);
        }

        public OnboardingViewModel()
        {
                         //create onboarding items
            Items = new ObservableRangeCollection<OnboardingModel>
            {
                new OnboardingModel
                {
                    Title = "Fisher Spot",
                    Content ="Bigmouth buffalo, North American darter mahi-mahi bigeye squaretail surfperch silver dollar." +
                    " Daggertooth pike conger paddlefish gouramie pearl danio mummichog waryfish grass carp, " +
                    "common carp striped bass Black swallower graveldiver sabertooth.",
                    Image ="OnboardingImage1.png"
                },

                new OnboardingModel
                {
                    Title = "Nature and Fish",
                    Content ="Bull shark escolar pomfret arapaima daggertooth pike conger sand stargazer," +
                    " California smoothtongue. Pickerel beluga sturgeon horsefish, Peter's" +
                    " elephantnose fish threadtail barfish Rattail fierasfer desert pupfish.",
                    Image ="OnboardingImage2"
                },


                new OnboardingModel
                {
                    Title = "Fishing near me",
                    Content ="Bigmouth buffalo, North American darter mahi-mahi bigeye squaretail surfperch silver dollar. " +
                    "Daggertooth pike conger paddlefish gouramie pearl danio mummichog waryfish grass carp," +
                    " common carp striped bass Black swallower graveldiver sabertooth.",
                    Image ="OnboardingImage3"
                },


               
            };
        }
    }
}
