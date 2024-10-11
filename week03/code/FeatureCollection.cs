public class FeatureCollection
{
    public string Type { get; set; }
    public MetaData MetaData { get; set; }
    public double[] BBox { get; set; }
    public Feature[] Features { get; set; }

    // public string PlaceAndMagnitudeToString()
    // {
    //     return $"{Features[0].Properties.Place} - mag {Features[0].Properties.Mag}";
    // }
}

public class MetaData
{
    public long Generated { get; set; }
    public string Url { get; set; }
    public string Title { get; set; }
    public string Api { get; set; }
    public int Count { get; set; }
    public int Status { get; set; }
}

public class Feature
{
    public string Type { get; set; }  // "Feature"
    public Property Properties { get; set; }
    public Geometry Geometry { get; set; }
    public string Id { get; set; }
}

public class Property
{
    public double Mag { get; set; }  // Decimal magnitude
    public string Place { get; set; }  // Place description
    public long Time { get; set; }  // Long integer for timestamp
    public long Updated { get; set; }  // Long integer for updated time
    public int? Tz { get; set; }  // Time zone (nullable int if not always present)
    public string Url { get; set; }  // URL for more details
    public string Detail { get; set; }  // Detail URL
    public int? Felt { get; set; }  // Nullable int for number of reports
    public double? Cdi { get; set; }  // Nullable decimal for intensity
    public double? Mmi { get; set; }  // Nullable decimal for shaking potential
    public string Alert { get; set; }  // Alert level
    public string Status { get; set; }  // Status of event
    public int? Tsunami { get; set; }  // Nullable int for tsunami status
    public int Sig { get; set; }  // Significance of event
    public string Net { get; set; }  // Network code
    public string Code { get; set; }  // Event code
    public string Ids { get; set; }  // List of IDs (e.g., event IDs)
    public string Sources { get; set; }  // Sources of information
    public string Types { get; set; }  // Types of data available
    public int? Nst { get; set; }  // Number of stations reporting the event
    public double? Dmin { get; set; }  // Decimal for minimum distance
    public double Rms { get; set; }  // Decimal for root mean square
    public double? Gap { get; set; }  // Decimal for gap value
    public string MagType { get; set; }  // Type of magnitude (e.g., mb, ms, etc.)
    public string Type { get; set; }  // Type of event (e.g., earthquake, explosion)
}

public class Geometry
{
    public string Type { get; set; }
    public double[] Coordinates { get; set; }
}
