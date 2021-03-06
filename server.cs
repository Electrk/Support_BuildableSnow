if ( !isFunction ("getClosestPaintColor") )
{
	exec ("./lib/getClosestPaintColor.cs");
}

exec ("./lib/Support_CreateBrick.cs");
exec ("./lib/Support_SemVer.cs");

// ------------------------------------------------


// Default snow bricks.
exec ("./bricks/datablocks.cs");

// Constant values.
exec ("./constants.cs");

// Configurable variables that can be changed by mods.
exec ("./config.cs");

// Main code.
exec ("./grid/exec.cs");
exec ("./createBrick.cs");
exec ("./snowVertices.cs");
exec ("./updateSnow.cs");
exec ("./raiseLower.cs");
exec ("./package.cs");

// Code for checking the version of this mod.
exec ("./version.cs");

// Functions that only work in debug mode.
exec ("./debug.cs");
