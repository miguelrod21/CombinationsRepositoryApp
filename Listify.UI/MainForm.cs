using Listify.Integration.Lottery;
using Listify.Repositories.LotteryCombinations;
using Listify.Repositories.LotteryCombinations.Dtos;

namespace ListifyApp
{
    public partial class MainForm : Form
    {
        private readonly ILotteryService _lotteryService;
        public MainForm(ILotteryService lotteryService)
        {
            _lotteryService = lotteryService;

            InitializeComponent();
        }

        public List<CombinationDto> LoadCombinations()
        {
            var all = _lotteryService.GetAll();

            return all;
        }
    }
}
