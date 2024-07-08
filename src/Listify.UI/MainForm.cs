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
            if (all == null) return null;

            List<string> allFormated = all.Select(x => string.Format("[{0} {1} {2} {3} {4} {5}]",
                x.N1.ToString(),
                x.N2.ToString(),
                x.N3.ToString(),
                x.N4.ToString(),
                x.N5.ToString(),
                x.N6.ToString()
                )).ToList();
            allFormated = allFormated.Take(10).ToList();
            foreach(var item in allFormated)
                combinationslvw.Items.Add(item);

            return all;
        }

        private List<CombinationDto> LoadCheckedCombinations()
        {
            var allChecked = _lotteryService.GetAllChecked();

            return allChecked;
        }
    }
}
