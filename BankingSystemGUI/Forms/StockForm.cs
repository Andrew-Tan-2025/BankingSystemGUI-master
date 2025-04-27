using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingSystemGUI.Models;
using BankingSystemGUI.Services;

namespace BankingSystemGUI.Forms
{
    public partial class StockForm : Form
    {
        private readonly StockService _stockService;

        public StockForm()
        {
            InitializeComponent();
            _stockService = new StockService();
            LoadExistingStocks();
        }

        private void LoadExistingStocks()
        {
            lstStocks.Items.Clear();
            var stocks = _stockService.GetAllStocks();
            
            if (stocks.Count == 0)
            {
                lstStocks.Items.Add("No stock data available. Click 'Build Stock Data' to get started.");
                return;
            }

            foreach (var stock in stocks)
            {
                lstStocks.Items.Add(stock.ToString());
            }
        }

        private async void btnBuildStocks_Click(object sender, EventArgs e)
        {
            string url = txtStockUrl.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Please enter a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add http:// if not provided
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
                txtStockUrl.Text = url;
            }

            btnBuildStocks.Enabled = false;
            txtStockUrl.Enabled = false;
            lblStatus.Text = "Building stock data...";
            Application.DoEvents();

            try
            {
                string filePath = await _stockService.StockbuildAsync(url);
                lblStatus.Text = $"Stock data saved successfully!";
                LoadExistingStocks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error building stock data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Error: Failed to build stock data.";
                // Try to load existing stocks anyway (we generate sample data in case of errors)
                LoadExistingStocks();
            }
            finally
            {
                btnBuildStocks.Enabled = true;
                txtStockUrl.Enabled = true;
            }
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            string symbol = txtSymbol.Text.Trim().ToUpper();
            
            if (string.IsNullOrWhiteSpace(symbol))
            {
                MessageBox.Show("Please enter a stock symbol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string quote = _stockService.Stockquote(symbol);
            lblQuoteResult.Text = quote;
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            // Add some alternative URLs
            cmbPresetUrls.Items.Add("finance.yahoo.com/most-active");
            cmbPresetUrls.Items.Add("www.marketwatch.com/investing/stocks");
            cmbPresetUrls.Items.Add("www.wsj.com/market-data/stocks");
            cmbPresetUrls.SelectedIndex = 0;
        }

        private void cmbPresetUrls_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPresetUrls.SelectedItem != null)
            {
                txtStockUrl.Text = cmbPresetUrls.SelectedItem.ToString();
            }
        }
    }
}