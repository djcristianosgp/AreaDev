﻿using Newtonsoft.Json;

namespace Monitores.Classes.Cripto
{
    public class Parametros
    {
        public class RetornoDados
        {
            public modoticker ticker { get; set; }
            public dynamic[] orderbook { get; set; }
            public dynamic[] trades { get; set; }
        }
        public class modoticker
        {
            public string high { get; set; }
            public string low { get; set; } 
            public string vol { get; set; } 
            public string last { get; set; }
            public string buy { get; set; } 
            public string sell { get; set; }
            public string open { get; set; }
            public double date { get; set; }
        }
        public class modoorderbook
        {
            public string[] bids { get; set; }
            public string[] asks { get; set; }           
        }
        public class modotrades
        {
            
            public double date { get; set; }
            public string price { get; set; }
            public string amount { get; set; }
            public int tid { get; set; }
            public string type { get; set; }
        }

        public static string sUrlConsulta = "https://www.mercadobitcoin.net/api/{0}/{1}/";

        public static DateTime ConvertUnixDateTime(double date)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(date).ToLocalTime();
            return dateTime;
        }

        public static RetornoDados Buscadados(string criptomoeda, string tipoconsulta)
        {
            var Retorno = new RetornoDados();
            try
            {
                string endipoint = String.Format(sUrlConsulta, criptomoeda.Split(':')[0].Trim(), tipoconsulta.Split(':')[0].Trim());
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Clear();

                    var vJson = client.GetStringAsync(endipoint).Result;
                    string sJson = JsonConvert.SerializeObject(vJson);
                    //JObject json = JObject.Parse(vJson);
                    //var vretorno = System.Text.Json.JsonSerializer.Deserialize<RetornoDados>(vJson);
                    Retorno = System.Text.Json.JsonSerializer.Deserialize<RetornoDados>(vJson);
                    return Retorno ;
                }
            }
            catch
            {
                return Retorno;
            }
        }


        public static Dictionary<string, string> parametroCripto = new Dictionary<string, string>() {
            {"ticker","resumo de operações executadas" },
            {"orderbook","livro de negociações, ordens abertas de compra e venda" },
            {"trades","histórico de operações executadas" }
        };

        public static Dictionary<string, string> tipoCripto = new Dictionary<string, string>() {
            {"AAVE","Aave"},
            {"ABFY","Ambify"},
            {"ACH","Alchemy Pay"},
            {"ACMFT","AC Milan"},
            {"ACORDO01","None"},
            {"ADA","Cardano"},
            {"ADS","Adshares"},
            {"AGIX","SingularityNET"},
            {"AIOZ","Aioz"},
            {"ALCX","Alchemix"},
            {"ALGO","Algorand"},
            {"ALICE","MyNeighborAlice"},
            {"ALLFT","Alliance"},
            {"ALPHA","Alpha Venture Dao"},
            {"AMFT","Aston Martin Cognizant"},
            {"AMP","Amp"},
            {"ANKR","ANKR"},
            {"ANT","Aragon"},
            {"APE","ApeCoin"},
            {"API3","API3"},
            {"APT","Aptos"},
            {"ARGFT","Argentine Football Association"},
            {"ASRFT","AS Roma"},
            {"ATLAS","Star Atlas"},
            {"ATMFT","Fan Token ATM"},
            {"ATOM","Cosmos"},
            {"AUDIO","Audius"},
            {"AVAX","Avalanche"},
            {"AXS","Axie Infinity"},
            {"BADGER","Badger DAO"},
            {"BAL","Balancer"},
            {"BAND","Band Protocol"},
            {"BARFT","FC Barcelona"},
            {"BAT","Basic Attention token"},
            {"BCH","Bitcoin Cash"},
            {"BICO","Biconomy"},
            {"BLZ","Bluzelle"},
            {"BNT","BANCOR"},
            {"BTB05","BT Token Black 05"},
            {"BTB10","BT Token Black 10"},
            {"BTC","Bitcoin"},
            {"BTRST","Braintrust"},
            {"CAIFT","Fan Token CAI"},
            {"CEEK","CEEK VR"},
            {"CHZ","Chiliz"},
            {"CITYFT","Manchester City FC"},
            {"CLV","Clover Finance"},
            {"COMP","Compound"},
            {"COTI","COTI"},
            {"CRV","Curve Dao Token"},
            {"CSCONS01","Consorcio CS01"},
            {"CSCONS02","Consorcio CS02"},
            {"CSCONS03","Consórcio CS03"},
            {"CSCONS04","Consorcio CS04"},
            {"CSCONS05","Consorcio CS05"},
            {"CTSI","Cartesi"},
            {"CVC","Civic"},
            {"CVX","Convex Finance"},
            {"DAI","Dai"},
            {"DG","Decentral Games"},
            {"DIA","DIA"},
            {"DOGE","Dogecoin"},
            {"DOT","Polkadot"},
            {"DPI","DeFi Pulse Index"},
            {"DYDX","dYdX"},
            {"ENER01","Token de Energia"},
            {"ENER02","Energia 02"},
            {"ENER03","Energia 03"},
            {"ENJ","Enjin Coin"},
            {"ENS","Ethereum Name Service"},
            {"ERN","Ethernity"},
            {"ETH","Ethereum"},
            {"FARM","Harvest Finance"},
            {"FET","Fetch.ai"},
            {"FIL","Filecoin"},
            {"FLOKI","Floki Inu"},
            {"FLOW","Flow"},
            {"FTM","None"},
            {"GALA","Gala"},
            {"GALFT","Galatasaray"},
            {"GALOFT","Clube Atletico Mineiro"},
            {"GHST","Aavegotchi"},
            {"GMT","STEPN"},
            {"GNO","Gnosis"},
            {"GODS","Gods Unchained"},
            {"GRT","The Graph"},
            {"GST","Green Satoshi Token"},
            {"HIGH","Highstreet"},
            {"HNT","None"},
            {"HOT","Holo"},
            {"ICP","Internet Computer"},
            {"ILV","Illuvium"},
            {"IMOB01","None"},
            {"IMOB02","None"},
            {"IMX","Immutable X'"},
            {"INTERFT","Inter Milan"},
            {"JASMY","JasmyCoin"},
            {"JUVFT","Juventus"},
            {"KEEP","Keep Network"},
            {"KNC","Kyber Network"},
            {"KP3R","Keep3rV1"},
            {"KSM","Kusama"},
            {"LDO","Lido DAO Token"},
            {"LINK","Chainlink"},
            {"LOOKS","LooksRare"},
            {"LPT","Livepeer"},
            {"LQTY","Liquity"},
            {"LRC","Loopring"},
            {"LTC","Litecoin"},
            {"MANA","MANA (Decentraland)"},
            {"MATIC","Polygon"},
            {"MBCCSH01","Consorcio H01"},
            {"MBCCSH02","Consorcio H02"},
            {"MBCCSH03","Consorcio H03"},
            {"MBCCSH04","Consorcio H04"},
            {"MBCCSH05","Consorcio H05"},
            {"MBCCSH06","Consorcio H06"},
            {"MBCCSH07","Consorcio H07"},
            {"MBCCSH08","Consorcio H08"},
            {"MBCCSH09","Consorcio H09"},
            {"MBCONS01","Cota de Consórcio 01"},
            {"MBCONS02","Cota de Consórcio 02"},
            {"MBFP01","None"},
            {"MBFP02","None"},
            {"MBFP03","Fluxo de Pagamento 03"},
            {"MBFP04","Fluxo de pagamento 04"},
            {"MBFP05","None"},
            {"MBFP06","Fluxos de Pagamento 06"},
            {"MBFP07","Fluxos de Pagamento 07"},
            {"MBFP08","Fluxos de Pagamento 08"},
            {"MBFP09","Fluxos de Pagamento 09"},
            {"MBFP10","Fluxos de Pagamento 10"},
            {"MBFP11","Fluxos de Pagamento 11"},
            {"MBFP12","Fluxos de Pagamento 12"},
            {"MBPRK01","Precatório MB SP01"},
            {"MBPRK02","Precatório MB SP02"},
            {"MBPRK03","Precatório MB BR03"},
            {"MBPRK04","Precatório MB RJ04"},
            {"MBPRK05","Fluxo de Pagamentos 5"},
            {"MBPRK06","Precatorio MB BR06"},
            {"MBPRK07","Precatorio MB SP07"},
            {"MBRL","MBRL"},
            {"MBSANTOS01","Token da Vila"},
            {"MBTKN01","MB TOKEN"},
            {"MBVASCO01","Vasco Token"},
            {"MC","Merit Circle"},
            {"MCO2","Moss Carbon Credit"},
            {"MENGOFT","Flamengo"},
            {"METIS","MetisDAO"},
            {"MINA","Mina"},
            {"MIR","Mirror Protocol"},
            {"MKR","Maker"},
            {"MPL","Maple"},
            {"MVI","Metaverse Index"},
            {"NAVIFT","Natus Vincere"},
            {"NFT00","Vale do Outback de 100 reais"},
            {"NFT10","Iasy Tata"},
            {"NFT11","NFT Feirante Abaetetubense"},
            {"NFT12","NFT Facas Feitas"},
            {"NFT13","NFT Mandala Yawanawa - Mariri a roda 2"},
            {"NFT14","Dodge Dart Sedan 1970 Verde Imperial"},
            {"NFT15","Dodge Dart Coupe 1971 Vermelho Etrusco"},
            {"NFT16","Dodge Charger LS 1974 White"},
            {"NFT17","Dodge Charger LS 1974 Black"},
            {"NFT18","Combo de Dodges"},
            {"NFT19","Teleton"},
            {"NFT2","NFT Protetores da Floresta"},
            {"NFT20","Topa tudo por dinheiro"},
            {"NFT21","De casa nova"},
            {"NFT22","Onde tudo comecou"},
            {"NFT23","Matriarca e Patriarca"},
            {"NFT24","Surui Riqueza e Autenticidade"},
            {"NFT25","Teoria do Caos"},
            {"NFT26","Tartarugas do rio Guapore"},
            {"NFT27","Viajantes de Asas"},
            {"NFT28","Talvez ele toque o ceu"},
            {"NFT29","Observador"},
            {"NFT3","NFT Protetores da Floresta - Peixe Mandy"},
            {"NFT30","Luta"},
            {"NFT31","Futuro"},
            {"NFT32","Construcao"},
            {"NFT33","Protetores da Floresta -Territorio Ancestral"},
            {"NFT34","Protetores da Floresta - Protectores de la vida"},
            {"NFT35","Protetores da Floresta - Peixe Tucunare"},
            {"NFT36","Protetores da Floresta - O que voce come"},
            {"NFT37","Protetores da Floresta - 2"},
            {"NFT38","Maneva - Album Mundo Novo"},
            {"NFT39","Frontispicio #1"},
            {"NFT4","NFT Error"},
            {"NFT40","Frontispicio #2"},
            {"NFT41","Frontispicio #3"},
            {"NFT42","Anguereco"},
            {"NFT43","Black Angel - #1"},
            {"NFT44","Black Angel - #2"},
            {"NFT45","Black Angel - #3"},
            {"NFT46","Black Angel - #4"},
            {"NFT47","Black Angel - #5"},
            {"NFT48","Black Angel - #6"},
            {"NFT49","Cryptoyabas - #1"},
            {"NFT5","NFT Simulation"},
            {"NFT50","Cryptoyabas - #2"},
            {"NFT51","Cryptoyabas - #3"},
            {"NFT52","Cryptoyabas - #4"},
            {"NFT53","Cryptoyabas - #5"},
            {"NFT54","Cryptoyabas - #6"},
            {"NFT55","Cryptoyabas - #7"},
            {"NFT56","Cryptoyabas - #8"},
            {"NFT57","Cryptoyabas - #9"},
            {"NFT58","Um chamado para descentralizacao - #1"},
            {"NFT59","Um chamado para descentralizacao - #2"},
            {"NFT6","NFT Cosmovisao Tupinamba da Amazonia"},
            {"NFT60","Um chamado para descentralizacao - #3"},
            {"NFT61","Um chamado para descentralizacao - #4"},
            {"NFT62","Um chamado para descentralizacao - #5"},
            {"NFT63","Um chamado para descentralizacao - #6"},
            {"NFT64","Diva I"},
            {"NFT65","Lua Nova em 12 por cento"},
            {"NFT66","Lua Crescente em 49 por cento"},
            {"NFT67","Desenho de agenda #1"},
            {"NFT68","Desenho de agenda #2"},
            {"NFT69","Desenho de agenda #3"},
            {"NFT7","NFT Barbara Parawara"},
            {"NFT70","Luar em 432 hertz"},
            {"NFT71","'Dois mundos unidos pelo amor. Inspirado pelo amor no amor atraves do Metaverso' - Thayllane"},
            {"NFT72","'O Metaverso com personagens da Disney.' - Maria Vitoria"},
            {"NFT73","'O mundo mais doce' - Larissa"},
            {"NFT74","'Meu mini universo, com varios biomas diferentes' - Carlos Eduardo (Cadu)"},
            {"NFT75","'O Multiverso da Nike' - Luiz"},
            {"NFT76","'Um Metaverso repleto de novos amigos' - Thomaz"},
            {"NFT77","'Metanimal: O mundo dos animais.' - Davi Batista"},
            {"NFT78","'O Metaverso colorido e divertido' - Rebeca Maria"},
            {"NFT79","'Um mundo novo, atraves dos oculos' - Deivid L."},
            {"NFT8","NFT Liberdade de sentir"},
            {"NFT80","'Um mundo colorido, onde a alegria nao acaba' - Ana Julia"},
            {"NFT81","'Metaverso do PS3, se voce chegar na arvore, voce ganha todos' Daniel Batista"},
            {"NFT82","'Metaverso com muitas brincadeiras' Marcos Pedro"},
            {"NFT83","'Metadoce, o mundo dos doces' Ana Bela"},
            {"NFT84","'Um estranho gigante de um mundo distante' Luiz Miguel"},
            {"NFT85","'Uma cidade feliz e outra triste' Anne Elis"},
            {"NFT86","'O mundo em que voce pode ser o que voce quiser' Maikon Freire"},
            {"NFT87","'Um Metaverso com zumbis' Carlos Henrique"},
            {"NFT88","'Um universo com muitos amigos e brincadeiras' Luiz Gustavo"},
            {"NFT89","'Um Metaverso de Minecraft colorido' Pedro Gabriel"},
            {"NFT9","NFT Pescaria"},
            {"NFT91","NFT.Rio | Exposicao"},
            {"NFT92","NFT.Rio | Talks e Masterclass"},
            {"NFTI","NFT Index"},
            {"NFTOKN01","Cesta de NFTs"},
            {"NODL","Nodle"},
            {"OCEAN","Ocean Protocol"},
            {"OGFT","OG eSports"},
            {"OGN","Origin Protocol"},
            {"OMG","Omg Network"},
            {"OP","Optimism"},
            {"OPUL","Opulous"},
            {"OXT","Orchid"},
            {"PAXG","PAX Gold"},
            {"PERP","Perpetual Protocol"},
            {"PFLFT","Professional Fighters League"},
            {"PLA","PlayDapp"},
            {"POLS","Polkastarter"},
            {"POLY","Polymath"},
            {"PORFT","Portugal National Team FT"},
            {"POWR","Power Ledger"},
            {"PSGFT","Paris Saint-Germain"},
            {"QNT","Quant"},
            {"RACA","Radio Caca"},
            {"RAD","Radicle"},
            {"RARE","SuperRare"},
            {"RARI","Rarible"},
            {"REN","Ren"},
            {"REQ","Request"},
            {"RLY","Rally"},
            {"RNDR","Render Token"},
            {"ROSE","Oasis Network"},
            {"SACI","Sport Club Internacional"},
            {"SAND","The Sandbox"},
            {"SAUBERFT","Alfa Romeo Racing ORLEN"},
            {"SCCPFT","Corinthians"},
            {"SDAO","SingularityDAO"},
            {"SHIB","Shiba Inu"},
            {"SKL","SKALE Network"},
            {"SLP","Smooth Love Potion"},
            {"SNX","Synthetix"},
            {"SOL","Solana"},
            {"SPELL","Spell Token"},
            {"SPFCFT","SPFC"},
            {"SRM","Serum"},
            {"STG","Stargate FInance"},
            {"STORJ","Storj"},
            {"STVFT","Sint-Truidense Voetbalvereniging"},
            {"STX","Stacks"},
            {"SUPER","SuperFarm"},
            {"SUSHI","SushiSwap"},
            {"SYN","Synapse"},
            {"THFT","Team Heretics"},
            {"TLM","Alien Worlds"},
            {"TRB","Tellor"},
            {"TRU","TrueFi"},
            {"UFCFT","UFC"},
            {"UMA","Uma"},
            {"UNI","Uniswap"},
            {"USDC","USD Coin"},
            {"USDP","Pax Dollar"},
            {"VERDAO","Sociedade Esportiva Palmeiras"},
            {"VSPRK01","Precatorio VS SP01"},
            {"WBTC","Wrapped Bitcoin"},
            {"WBX","WiBX"},
            {"WLUNA","Wrapped LUNA Token"},
            {"XLM","Stellar"},
            {"XRP","XRP"},
            {"XTZ","Tezos"},
            {"YBOFT","BSC Young Boys"},
            {"YFI","yearn.finance"},
            {"YGG","Yield Guild Games"},
            {"ZRX","0x"},
            {"FTBRL","None"}
        };
    }
}
