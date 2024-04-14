using Microsoft.Extensions.Logging;

namespace Compras
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Poppins-Light.ttf", "PoppinsLight");
                    fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");//PoppinsRegular
                    fonts.AddFont("Poppins-ExtraBold.ttf", "PoppinsExtraBold");//PoppinsExtraBold
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
