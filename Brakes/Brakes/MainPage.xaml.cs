using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Brakes
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<string> _brakepad;   //initialising strings
        public MainPage()
        {
            this.InitializeComponent();
            setupListsOfDescription();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }//main page
        //text for the app pages
        private void setupListsOfDescription()
        {
            if (_brakepad != null)  //if statement
            {
                return;
            }
            _brakepad = new List<string>();

            _brakepad.Add("The first task when changing your own brake pads is to find somewhere safe to do it. The most important thing to remember when changing them is that solid ground is needed in order for the car to be jacked up safely, I recommend a shed with a concrete floor and electricity. Then you have access to light and a well lit working area makes everything much easier. It is also much safer as there is no wind shaking the car or weather interveining in the job at hand. If a shed is not an option for you wait for a non windy day and find a spot outside with solid ground e.g. concrete, Tarmac. ");
            _brakepad.Add("The next thing needed is the parts, I am going to presume you need new brake pads all around the car. You will need to buy two sets of front and rear brakes. These range in price depending on what make and model your car is, however for most everyday cars the price for a two sets of front brake pads is between €30 and €60. The cost for two sets of brake pads for the back wheels is between €50 and €70. Brake pads for your car can be bought online eg. eBay or Amazon or in your local motor factors. ");
            _brakepad.Add("Up next is what tools will be needed for this job. firt up is a C-clamp, This will press on the caliper assembly and push the piston all the way in, resetting the brake once the new pads are in. The next tool is a wrench to remove the caliper bolts, depending on the vehicle you might need an Allen or Torx wrench for this. The next tool is a lug wrench to remove the wheel nuts, gloves, a dust mask and safety glasses. Finally then some sort of jack is needed to lift the car, whether it be a trolley jack, hyrolic jack, bottle jack or a tension jack");
            _brakepad.Add("This is where the fun starts.\n Step 1 - bring car into shed and turn lights on.\n Step 2 - put on all necessary safety gear.\n Step 3 - Jack up car until the wheel is about half an inch off the ground.\n Step 4 - Undo the wheel nuts with the lug wrench and remove wheel.\n Step 5 - remove the small thin clip from the front of the brake caliper.\n Step 6 - remove the two dust caps on the top and bottom of the caliper on the inside.\n Step 7 - remove the two screws that the dustcap was covering using the Allen wrench.\n Step 8 - Remove the caliper from the brake disc.\n Step 9 - Take out the two old pads from inside the caliper by simply unclipping them.\n Step 10 - Use the C clamp to push the piston in the caliper back in order to fit in the new pads.\n Step 11 - Clip in the two new calipers.\n Step 12 - Attach the caliper back to the disc and screw back in.\n Step 13 - place in the dust caps again and re-attach meatl clip on front of the caliper.\n Step 14 - Screw the wheel back on and finally,\n Step 15 - Lower car from jack slowly and carefully. Repeat these steps for each wheel ");
            _brakepad.Add("Different makes and models can all be slightly different when doing something like changing the brake pads, The car I am referencing through this app is my own 2006 BMW 3-Series e90 Msport. They can vary between how many wheel nuts are on a car, for instance the BMW has five while the 2006 Toyota Corolla has four. The screws might be in slightly different areas behind the caliper. Theere might be dust caps missing. Instead of a size 7 Allen wrench you might need a different size or maybe a torx wrench. Hoever the way the are all changed apart from thos differences is nearly identical so you shouldnt have much problems with it. ");
            _brakepad.Add("Time Taken to complete this task can fluxuate massively depending on a number of factors \n- Amount of wheels to be done. \n- Locating of the screws with the Allen wrench. \n -Stiffness of the caliper on the disc. \n -Stiffnes of the caliper when removing and replacing new pads. \n However taking into account that everything goes well it should take about 15 to 20 minutes per wheel, so it should take just over an hour.");
            _brakepad.Add("By taking time out to do this quite simple proceedure you could easily save yourself €200 (what I saved doing it myself) in comparison to going to the garage and paying fro them to aquire the parts and then paying for the labour on top of that, that is why I think everybody should be able to change their own brakes as it is very simplce and saves a lot of money. ");
            _brakepad.Add("After you have all your brake pads changed it is important that you bring your car out for a cautious test drive to make sure they are now working properly. Drive slowly somewhere quite and check them by softly braking and then harshly braking but make sure the road is quite so you dont cause an accident. It will take the new brakes a short space of time to be worn in and become sharper.");
            _brakepad.Add("I wanted to create an App that would be useful to everyone, I thaught that this was a very useful and money saving idea. Everything is so expensive now to do with cars or vehicles I thaught I could share my bit of knowledge with the world and help others learn something new too. ");


            int i;
            TextBlock curr;
            for (i = 0; i <= 8; i++)//for loop
            {
                curr = (TextBlock)pvtPad.FindName("tblAbout" + i.ToString());
                if (curr != null)
                {
                    curr.Text = _brakepad[i];
                }
            }
        }

    }//partial class
}//namespace
