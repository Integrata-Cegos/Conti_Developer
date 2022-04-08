﻿string PlanetFromPosition(int position)
{
    string planetName = "unknown";
    if (position > 0 && position <= 9)
    {

        switch(position)
        {
            case 1:
                {
                    planetName = "Mercury";
                    break;
                }
            case 2:
                {
                    planetName = "Venus";
                    break;
                }
            case 3:
                {
                    planetName = "Earth";
                    break;
                }
            case 4:
                {
                    planetName = "Mars";
                    break;
                }
            case 5:
                {
                    planetName = "Jupiter";
                    break;
                }
            case 6:
                {
                    planetName = "Saturn";
                    break;
                }
            case 7:
                {
                    planetName = "Uranus";
                    break; 
                }
            case 8:
                {
                    planetName = "Neptune";
                    break;
                }
            case 9:
                {
                    planetName = "Pluto";
                    break;
                }
        }
    }
    return planetName;
}

void Application()
{
    foreach (string planetPoitionAsString in args)
    {
        int planetPosition = Convert.ToInt32(planetPoitionAsString);
        string planetName = PlanetFromPosition(planetPosition);
        Console.WriteLine("Planet with number {0} is {1}", planetPosition, planetName);
    }
}

Application();
