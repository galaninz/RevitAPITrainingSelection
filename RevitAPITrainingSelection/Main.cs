using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Mechanical;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingSelection
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            //IList<Reference> selectedElementRefList = uidoc.Selection.PickObjects(ObjectType.Element, new WallFilter(), "Выберите стены");
            //var wallList = new List<Wall>();

            //string info = string.Empty;
            //foreach (var selectedElement in selectedElementRefList)
            //{
            //    Wall oWall = doc.GetElement(selectedElement) as Wall;
            //    wallList.Add(oWall);
            //    var width = UnitUtils.ConvertFromInternalUnits(oWall.Width, UnitTypeId.Millimeters);
            //    info+=$"Name: {oWall.Name}, width: {width}{Environment.NewLine}";
            //}

            //info += $"Количество: {wallList.Count}";

            //TaskDialog.Show("Selection", info);

            //XYZ pickedPoint = null;

            //try
            //{
            //    pickedPoint = uidoc.Selection.PickPoint(ObjectSnapTypes.Endpoints, "Выберите точку");
            //}
            //catch (Autodesk.Revit.Exceptions.OperationCanceledException)
            //{}

            //if (pickedPoint == null)
            //    return Result.Cancelled;

            //TaskDialog.Show("Point info", $"X: {pickedPoint.X}, Y: {pickedPoint.Y}, Z: {pickedPoint.Z}");

            //List<FamilyInstance> familyInstances = new FilteredElementCollector(doc)
            //    .OfCategory(BuiltInCategory.OST_Doors)
            //    .WhereElementIsElementType()
            //    .Cast<FamilyInstance>()
            //    .ToList();

            //TaskDialog.Show("Doors count", familyInstances.Count.ToString());

            //List<FamilyInstance> familyInstances = new FilteredElementCollector(doc, doc.ActiveView.Id)
            //    .OfCategory(BuiltInCategory.OST_Doors)
            //    .WhereElementIsNotElementType()
            //    .Cast<FamilyInstance>()
            //    .ToList();

            //TaskDialog.Show("Doors count", familyInstances.Count.ToString());

            //var walls = new FilteredElementCollector(doc)
            //    .OfClass(typeof(Wall))
            //    .Cast<Wall>()
            //    .ToList();

            //TaskDialog.Show("Wall info", walls.Count.ToString());

            //ElementCategoryFilter windowCategoryFilter = new ElementCategoryFilter(BuiltInCategory.OST_Windows);
            //ElementClassFilter windowsIntancesFilter = new ElementClassFilter(typeof(FamilyInstance));

            //LogicalAndFilter windowsFilter = new LogicalAndFilter(windowCategoryFilter, windowsIntancesFilter);

            //var windows = new FilteredElementCollector(doc)
            //                  .WherePasses(windowsFilter)
            //                  .Cast<FamilyInstance>()
            //                  .ToList();

            //TaskDialog.Show("Windows info", windows.Count.ToString());

            //List<FamilySymbol> doorTypes = new FilteredElementCollector(doc)
            //    .OfCategory(BuiltInCategory.OST_Doors)
            //    .WhereElementIsElementType()
            //    .Cast<FamilySymbol>()
            //    .ToList();

            //TaskDialog.Show("Door types info", doorTypes.Count.ToString());

            //По категории

            //List<FamilyInstance> familyInstances = new FilteredElementCollector(doc)
            //    .OfCategory(BuiltInCategory.OST_DuctCurves)
            //    .WhereElementIsNoElementType()
            //    .Cast<FamilyInstance>()
            //    .ToList();

            //TaskDialog.Show("Ducts count", familyInstances.Count.ToString());

            //По типу

            var ducts = new FilteredElementCollector(doc)
                .OfClass(typeof(Duct))
                .Cast<Duct>()
                .ToList();

            TaskDialog.Show("Ducts quantity", ducts.Count.ToString());

            return Result.Succeeded;
        }
    }
}
