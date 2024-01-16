using Godot;
using System;
static class iisst
{
	public static float dogtop;
	public static float cat1top;
	public static float cat2top;
	public static float cat3top;
	public static float cat4top;
	public static float dogbutton;
	public static float cat1button;
	public static float cat2button;
	public static float cat3button;
	public static float cat4button;
	public static float dogleft;
	public static float cat1left;
	public static float cat2left;
	public static float cat3left;
	public static float cat4left;
	public static float dogright;
	public static float cat1right;
	public static float cat2right;
	public static float cat3right;
	public static float cat4right;
	public static float mousetop;
	public static float mousebottom;
	public static float mouseleft;
	public static float mouseright;
	public static int jishu = 0;
	public static int dogy = 0;
}

public partial class node : Node2D
{
    public override void _Process(double delta)
    {
		bool o1 = iisst.mousebottom >= iisst.cat1top && iisst.mouseright >= iisst.cat1left && iisst.mousetop < iisst.cat1button && iisst.mouseleft <= iisst.cat1right;
		bool o2 = iisst.mousebottom >= iisst.cat2top && iisst.mouseright >= iisst.cat2left && iisst.mousetop < iisst.cat2button && iisst.mouseleft <= iisst.cat2right;
		bool o3 = iisst.mousebottom >= iisst.cat3top && iisst.mouseright >= iisst.cat3left && iisst.mousetop < iisst.cat3button && iisst.mouseleft <= iisst.cat3right;
		bool o4 = iisst.mousebottom >= iisst.cat4top && iisst.mouseright >= iisst.cat4left && iisst.mousetop < iisst.cat4button && iisst.mouseleft <= iisst.cat4right;
		bool o5 = iisst.mousebottom >= iisst.dogtop && iisst.mouseright >= iisst.dogleft && iisst.mousetop < iisst.dogbutton && iisst.mouseleft <= iisst.dogright;
		if (o1&&iisst.dogy!=0)
        {
			iisst.dogy--;
		}
		if (o2&&iisst.dogy!=0)
        {
			iisst.dogy--;
		}
        if (o3&&iisst.dogy!=0)
        {
			iisst.dogy--;
		}
        if (o4&&iisst.dogy!=0)
        {
			iisst.dogy--;
		}
		if((o1 || o2 || o3 || o4)&&iisst.dogy==0)
        {
			iisst.jishu = 0;
        }
        if (o5)
        {
			iisst.dogy++;
        }
        base._Process(delta);
    }
}