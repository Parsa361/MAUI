
/* Unmerged change from project 'Proj (net7.0-ios)'
Before:
using System.Collections.ObjectModel;
After:
using Microsoft.Maui.Controls;
*/

/* Unmerged change from project 'Proj (net7.0-windows10.0.19041.0)'
Before:
using System.Collections.ObjectModel;
After:
using Microsoft.Maui.Controls;
*/

/* Unmerged change from project 'Proj (net7.0-android)'
Before:
using System.Collections.ObjectModel;
After:
using Microsoft.Maui.Controls;
*/
using Proj.Models;
using System.Collections.ObjectModel;

namespace Proj
{
    public class FlexLayoutViewModel : BindableObject
    {
        private ObservableCollection<TreeModel> _trees;

        public ObservableCollection<TreeModel> Trees
        {
            get { return _trees; }
            set
            {
                _trees = value;
                OnPropertyChanged(nameof(Trees));
            }
        }

        public FlexLayoutViewModel()
        {
            // Sample data for trees
            Trees = new ObservableCollection<TreeModel>
            {
                new TreeModel { Name = "Oak Tree", GrowsOn = "Land", Photo = "oak_tree.jpg", Season = "Spring" },
                new TreeModel { Name = "Pine Tree", GrowsOn = "Mountain", Photo = "pine_tree.jpg", Season = "Winter" },
                new TreeModel { Name = "Maple Tree", GrowsOn = "Land", Photo = "maple_tree.jpg", Season = "Autumn" },
                new TreeModel { Name = "Willow Tree", GrowsOn = "Riverbank", Photo = "willow_tree.jpg", Season = "Summer" },
                new TreeModel { Name = "Birch Tree", GrowsOn = "Forest", Photo = "birch_tree.jpg", Season = "Spring" },
                new TreeModel { Name = "Cypress Tree", GrowsOn = "Swamp", Photo = "cypress_tree.jpg", Season = "Fall" },

                // Add more trees as needed
            };
        }
    }
}
