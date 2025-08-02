using SimplexNoise;

namespace OctavePerlinNoise;

public partial class Form1 : Form {
  public Form1() {
    this.InitializeComponent();

  }

  public static Bitmap GenerateMap(int width, int height, float scale, int octaves, float persistance,
    float lacunarity, int offsetX, int offsetY) {
    var map = new float[width, height];
    var image = new Bitmap(width, height);

    var maxValue = float.MinValue;
    var minValue = float.MaxValue;

    for (var y = 0; y < height; ++y)
      for (var x = 0; x < width; ++x) {
        var value = 0F;
        var frequency = 1F;
        var amplitude = 1F;

        for (var i = 0; i < octaves; ++i) {

          var noise = Noise.CalcPixel2D(x + offsetX, y + offsetY, scale * frequency) * amplitude;
          value += noise;

          frequency *= lacunarity;
          amplitude *= persistance;
        }

        map[x, y] = value;

        //get highest and lowest value
        if (value > maxValue)
          maxValue = value;
        if (value < minValue)
          minValue = value;
      }


    //normalize
    for (var y = 0; y < height; ++y)
      for (var x = 0; x < width; ++x) {
        var value = (map[x, y] - minValue) / (maxValue - minValue);
        map[x, y] = value;

        var colorValue = (int)(value * 255);
        image.SetPixel(x, y, Color.FromArgb(colorValue, colorValue, colorValue));
      }

    return image;
  }

  private void _BtnGenerate_Click(object sender, EventArgs e) {
    if (!int.TryParse(this.tbWidth.Text, out var width))
      return;
    if (!int.TryParse(this.tbHeight.Text, out var height))
      return;
    if (!float.TryParse(this.tbScale.Text, out var scale))
      return;
    if (!int.TryParse(this.tbOctaves.Text, out var octaves))
      return;
    if (!float.TryParse(this.tbPersistance.Text, out var persistence))
      return;
    if (!float.TryParse(this.tbLacunarity.Text, out var lacunarity))
      return;

    this.pbNoise.Image = GenerateMap(width, height, scale, octaves, persistence, lacunarity, 0, 0);
  }
}
