using MudBlazor;
using MudBlazor.Utilities;

namespace BXDavies.Layout;

// ReSharper disable once ClassNeverInstantiated.Global
public class Theme
{
    // Custom Mudblazor theme for Lighthouse Notes
    public static readonly MudTheme BXDaviesTheme = new()
    {
        
        // Dark mode
        PaletteDark = new PaletteDark
        {
            Primary = "#1CBFFF",
            Secondary = "#00CC6A",

            AppbarBackground = "#000000",
            AppbarText = "#ffffff",
            
            Background = "#000000",
            
            TextPrimary = "#ffffff"
        },

        // Z index
        ZIndex = new ZIndex
        {
            Drawer = 1301,
            Snackbar = 10010
        },

        // Typography
        Typography = new Typography
        {
            // All text
            Default = new Default
            {
                FontFamily = new[] { "Montserrat", "sans-serif" },
                FontWeight = 400
            },

            // Heading 1
            H1 = new H1
            {
                FontSize = "4rem",
                FontWeight = 400
            },

            // Heading 2
            H2 = new H2
            {
                FontSize = "3rem"
            }
        }
    };
}