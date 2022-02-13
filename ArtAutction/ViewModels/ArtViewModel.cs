using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ArtAutction.Models;

namespace ArtAutction.ViewModels
{
    public class ArtViewModel
    {
        public ObservableCollection<Arts> TheArtworks { get; set; } = new ObservableCollection<Arts>
        {
            new Arts{Image="tree",Price="$950,000",Title="Peach Tree in Blossom"},
            new Arts{Image="caffe",Price="$1,950,000",Title="Cafe Terace at Night"},
            new Arts{Image="cypresses",Price="$950,000",Title="Cypresses"},
            new Arts{Image="redvineyard",Price="$950,000",Title="The Red Vineyard"},
            new Arts{Image="awesomefield",Price="$950,000",Title="Awesome Field"},
            new Arts{Image="landscape",Price="$950,000",Title="Great Landscape"}
        };
    }
}
