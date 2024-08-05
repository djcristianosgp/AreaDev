using Supabase;

namespace area_27_dashboard.DB
{
    public class BaseModelSupabase
    {
        public Client GetConectionSupabase()
        {
            //var url = Environment.GetEnvironmentVariable("SUPABASE_URL");
            //var key = Environment.GetEnvironmentVariable("SUPABASE_KEY"); 
            var url = "https://apkanfxgjwkmkojmdnxx.supabase.co";
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFwa2FuZnhnandrbWtvam1kbnh4Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3MjI2MTgxNTAsImV4cCI6MjAzODE5NDE1MH0.vxImUMUyVAFR6DH99KNOEXe82FLa0kUXTl1jtT3UR_M";

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            var supabase = new Client(url, key, options);
            return supabase;
        }
    }
}
