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
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCombinations();
            LoadCheckedCombinations();
        }
        public List<CombinationDto> LoadCombinations()
        {
            var all = _lotteryService.GetAll();
            return all;
        }

        private List<CombinationDto> LoadCheckedCombinations()
        {
            var allChecked = _lotteryService.GetAllChecked();
            return allChecked;
        }
    }
}
