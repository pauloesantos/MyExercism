using System;

public class SpaceAge {

    public struct SecondYearsAndPlanets {

        public const double SecondsInEarthYear = 31557600;
        public const double MercuryToEarthYears = 0.2408467;
        public const double VenusToEarthYears = 0.61519726;
        public const double MarsToEarthYears = 1.8808158;
        public const double JupiterToEarthYears = 11.862615;
        public const double SaturnToEarthYears = 29.447498;
        public const double UranusToEarthYears = 84.016846;
        public const double NeptuneToEarthYears = 164.79132;
    }

    public SpaceAge (long spaceAgeValue) {
        AgesInSpace = spaceAgeValue;
    }

    public long AgesInSpace { get; private set; }

    public double OnEarth () {
        //throw new NotImplementedException ("You need to implement this function.");
        return AgesInSpace / SecondYearsAndPlanets.SecondsInEarthYear;
    }

    public double OnMercury () {
        //throw new NotImplementedException ("You need to implement this function.");
        return OnEarth () / SecondYearsAndPlanets.MercuryToEarthYears;
    }

    public double OnVenus () {
        //throw new NotImplementedException ("You need to implement this function.");
        return OnEarth () / SecondYearsAndPlanets.VenusToEarthYears;
    }

    public double OnMars () {
        //throw new NotImplementedException ("You need to implement this function.");
        return OnEarth () / SecondYearsAndPlanets.MarsToEarthYears;
    }

    public double OnJupiter () {
        //throw new NotImplementedException ("You need to implement this function.");
        return OnEarth () / SecondYearsAndPlanets.JupiterToEarthYears;
    }

    public double OnSaturn () {
        //throw new NotImplementedException ("You need to implement this function.");
        return OnEarth () / SecondYearsAndPlanets.SaturnToEarthYears;
    }

    public double OnUranus () {
        //throw new NotImplementedException ("You need to implement this function.");
        return OnEarth () / SecondYearsAndPlanets.UranusToEarthYears;
    }

    public double OnNeptune () {
        //throw new NotImplementedException ("You need to implement this function.");
        return OnEarth () / SecondYearsAndPlanets.NeptuneToEarthYears;
    }
}