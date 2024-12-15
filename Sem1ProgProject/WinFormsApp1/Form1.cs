using System.Text.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Recipe> recipes = new List<Recipe>();
        private string filePath = "recipes.json";

        public Form1()
        {
            InitializeComponent();
            LoadRecipesFromFile();
            DisplayRandomRecipe();
            // button events stuff
            btnSaveChanges.Click += btnSaveChanges_Click;
            btnEditRecipe.Click += btnEditRecipe_Click;
            btnDeleteRecipe.Click += btnDeleteRecipe_Click;
            btnViewRecipe.Click += btnViewRecipe_Click;
            btnNewRecipe.Click += btnNewRecipe_Click;
        }

        // save function
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string ingredientsText = txtIngredients.Text;
            string instructions = textInstructions.Text;
            List<string> ingredients = ingredientsText.Split(',').Select(i => i.Trim()).ToList();
            Recipe newRecipe = new Recipe(name, ingredients, instructions);
            recipes.Add(newRecipe);
            listBoxRecipes.Items.Add(newRecipe);
            SaveRecipesToFile();
            ClearTextBoxes();
            MessageBox.Show("Your New Recipe Has Been Saved!");
        }

        // saving the recipe to file
        private void SaveRecipesToFile()
        {
            string json = JsonSerializer.Serialize(recipes, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        // retrieves recipes from file
        private void LoadRecipesFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                recipes = JsonSerializer.Deserialize<List<Recipe>>(json);
                //listBoxRecipes.Items.Clear();
                foreach (var recipe in recipes)
                {
                    listBoxRecipes.Items.Add(recipe);
                }
            }
        }

        // editing the selected recipe 
        private void btnEditRecipe_Click(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedItem != null)
            {
                Recipe selectedRecipe = (Recipe)listBoxRecipes.SelectedItem;
                txtName.Text = selectedRecipe.Name;
                txtIngredients.Text = string.Join(", ", selectedRecipe.Ingredients);
                textInstructions.Text = selectedRecipe.Instructions;
                recipes.Remove(selectedRecipe);  // add or remove this for later??
                listBoxRecipes.Items.Remove(selectedRecipe);
            }
            else
            {
                MessageBox.Show("Please select a recipe to be able to edit it.");
            }
        }

        // deleting the selected recipe 
        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedItem != null)
            {
                Recipe selectedRecipe = (Recipe)listBoxRecipes.SelectedItem;
                recipes.Remove(selectedRecipe);
                listBoxRecipes.Items.Remove(selectedRecipe);
                SaveRecipesToFile();
                MessageBox.Show("Recipe Has Been Successfully Deleted.");
            }
            else
            {
                MessageBox.Show("Please select a recipe to delete it.");
            }
        }

        // view the selected recipe
        private void btnViewRecipe_Click(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedItem != null)
            {
                Recipe selectedRecipe = (Recipe)listBoxRecipes.SelectedItem;
                txtName.Text = selectedRecipe.Name;
                txtIngredients.Text = string.Join(", ", selectedRecipe.Ingredients);
                textInstructions.Text = selectedRecipe.Instructions;
            }
            else
            {
                MessageBox.Show("Please select a recipe to view it.");
            }
        }



        private void DisplayRandomRecipe()
        {
            if (recipes.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(recipes.Count);
                Recipe randomRecipe = recipes[randomIndex];
                txtNewRecipe.Text = randomRecipe.Name;
            }
            else
            {
                txtNewRecipe.Text = "No recipes available.";
            }
        }




        // random recipe generator when clicked
        private void btnNewRecipe_Click(object sender, EventArgs e)
        {
            if (recipes.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(recipes.Count);
                Recipe randomRecipe = recipes[randomIndex];
                txtNewRecipe.Text = randomRecipe.Name;
            }
            else
            {
                txtNewRecipe.Text = "No recipes available.";
                MessageBox.Show("No recipes have been saved yet, Please add some recipes.");
            }
        }

        // keep or delete, ui clear or delete stuff
        private void ClearTextBoxes()
        {
            txtName.Clear();
            txtIngredients.Clear();
            textInstructions.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureRecipe_Click(object sender, EventArgs e)
        {

        }

        private void pictureNewRecipe_Click(object sender, EventArgs e)
        {

        }
    }







// default recipe class
    public class Recipe
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public string Instructions { get; set; }

        public Recipe(string name, List<string> ingredients, string instructions)
        {
            Name = name;
            Ingredients = ingredients;
            Instructions = instructions;
        }

// listbox display 
        public override string ToString()
        {
            return Name;
        }
    }
}
