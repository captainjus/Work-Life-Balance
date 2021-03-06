﻿using UnityEngine;

public class Action
{
    public Action(float Time, float PH, float MH, float N, float E, float H, float AP, string name)
    {
        this.Time = Time;
        this.PhysHealth = PH;
        this.MentHealth = MH;
        this.Nutri = N;
        this.Energy = E;
        this.Hygiene = H;
        this.Ability = AP;
        this.name = name;
    }
    public float Time
    { get; set; }
    public float PhysHealth
    { get; set; }
    public float MentHealth
    { get; set; }
    public float Nutri
    { get; set; }
    public float Hygiene
    { get; set; }
    public float Energy
    { get; set; }
    public float Ability
    { get; set; }
    public string name
    { get; set; }

    public string toString()
    {
        return name;  
    }
}
public class ActionButton
{
    public Action actionToTake
    { get; set; }

}
