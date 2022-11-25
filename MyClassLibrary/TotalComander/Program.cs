using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace HW7
{
    class Program
    {
        static public string ChoseDrive(List<DriveInfo> drives, out bool exit)
        {
            string? myString;
            bool check;
            int thisInt;
            int search = 1;
            string name = "";

            do
            {
                Console.WriteLine("Chose drive ([0] Exit): ");
                myString = Console.ReadLine();
                check = int.TryParse(myString, out thisInt);
                if (!check || thisInt > drives.Count || thisInt < 0)
                {
                    Console.WriteLine("This drive does not exist. Try again!");
                }
            }
            while (!check || thisInt > drives.Count || thisInt < 0);

            if (thisInt == 0)
            {
                exit = true;
            }
            else
            {
                exit = false;
            }

            foreach (DriveInfo drive in drives)
            {
                if (thisInt == search)
                {
                    name = drive.Name;
                }
                search++;
            }
            return name;
        }

        static public string ChoseDrive(List<DriveInfo> drives)
        {
            string? myString;
            bool check;
            int thisInt;
            int search = 1;
            string name = "";

            do
            {
                Console.WriteLine("Chose drive: ");
                myString = Console.ReadLine();
                check = int.TryParse(myString, out thisInt);
                if (!check || thisInt > drives.Count || thisInt < 0)
                {
                    Console.WriteLine("This drive does not exist. Try again!");
                }
            }
            while (!check || thisInt > drives.Count || thisInt < 0);

            foreach (DriveInfo drive in drives)
            {
                if (thisInt == search)
                {
                    name = drive.Name;
                }
                search++;
            }
            return name;
        }
        static void Main(string[] args)
        {
            try
            {
                List<string> OpenFolder(string dirName)
                {
                    int i = 1;
                    int j = 1;
                    List<string> newDirectory = new List<string>();
                    if (Directory.Exists(dirName))
                    {
                        Console.WriteLine("Subfolder:");
                        string[] dirs = Directory.GetDirectories(dirName);
                        if (dirs.Length == 0) Console.WriteLine("- Empty -");
                        foreach (string dir in dirs)
                        {
                            Console.WriteLine($"{i}) {dir}");
                            newDirectory.Add(dir);
                            i++;
                        }
                        newDirectory.Add("Files:");
                        Console.WriteLine("Files:");
                        string[] files = Directory.GetFiles(dirName);
                        if (files.Length == 0) Console.WriteLine("- Empty -");
                        foreach (string file in files)
                        {
                            Console.WriteLine($"{j}) {file}");
                            newDirectory.Add(file);
                            j++;
                        }
                    }
                    return newDirectory;
                }

                List<string> CloseFolder(string dirName)
                {
                    int i = 1;
                    int j = 1;
                    List<string> newDirectory = new List<string>();
                    if (Directory.Exists(dirName))
                    {
                        Console.WriteLine("Subfolder:");
                        string[] dirs = Directory.GetDirectories(dirName);
                        if (dirs.Length == 0) Console.WriteLine("- Empty -");
                        foreach (string dir in dirs)
                        {
                            Console.WriteLine($"{i}) {dir}");
                            newDirectory.Add(dir);
                            i++;
                        }
                        newDirectory.Add("Files:");
                        Console.WriteLine("Files:");
                        string[] files = Directory.GetFiles(dirName);
                        if (files.Length == 0) Console.WriteLine("- Empty -");
                        foreach (string file in files)
                        {
                            Console.WriteLine($"{j}) {file}");
                            newDirectory.Add(file);
                            j++;
                        }
                    }
                    return newDirectory;
                }

                List<DriveInfo> ViewDrive()
                {
                    int i = 0;
                    List<DriveInfo> newDrives = new List<DriveInfo>();
                    Console.WriteLine("Chose drive");
                    DriveInfo[] drives = DriveInfo.GetDrives();
                    foreach (DriveInfo drive in drives)
                    {
                        if (drive.IsReady)
                        {
                            i++;
                            Console.WriteLine($"{i}) {drive.Name}");
                            newDrives.Add(drive);
                        }
                    }
                    return newDrives;
                }

                string ChoseFolder(List<string> drives)
                {
                    string? myString;
                    bool check;
                    int thisInt;
                    int search = 1;
                    string name = "";

                    do
                    {
                        Console.WriteLine("Chose file or folder you need: ");
                        myString = Console.ReadLine();
                        check = int.TryParse(myString, out thisInt);
                        if (!check || thisInt > drives.Count || thisInt < 1)
                        {
                            Console.WriteLine("This folder or file does not exist. Try again!");
                        }
                    }
                    while (!check || thisInt > drives.Count || thisInt < 1);

                    foreach (string drive in drives)
                    {
                        if (thisInt == search)
                        {
                            name = drive;
                        }
                        search++;
                    }
                    return name;
                }

                int ChoseAction(int circle)
                {
                    string? myString;
                    bool check;
                    int thisInt;

                    do
                    {
                        myString = Console.ReadLine();
                        check = int.TryParse(myString, out thisInt);
                        if (!check || thisInt > circle || thisInt < 1)
                        {
                            Console.WriteLine("Incorrect choice. Try again!");
                        }
                    }
                    while (!check || thisInt > circle || thisInt < 1);
                    return thisInt;
                }

                string BackForw(string myPlace, string placeForBack)
                {
                    int startWord = 0;
                    int finishWord = 0;
                    string myPlaceForBack = myPlace.Substring(0, myPlace.Length - 1);
                    finishWord = myPlaceForBack.Length;
                    startWord = myPlaceForBack.LastIndexOf('\\') + 1;

                    int n = myPlaceForBack.IndexOf(myPlaceForBack.Substring(startWord, finishWord - startWord));
                    return placeForBack = myPlaceForBack.Remove(n, myPlaceForBack.Substring(startWord, finishWord - startWord).Length);
                }

                void Open(ref List<string> chDirectory, ref List<string> newDirectory, ref string myPlace, ref string placeForBack)
                {


                    myPlace = ChoseFolder(chDirectory);

                    placeForBack = BackForw(myPlace, placeForBack);

                    newDirectory = OpenFolder(myPlace);
                }

                bool NoFolderFile(int i, ref List<string> chDirectory, ref List<string> newDirectory)
                {
                    if (i == 1)
                    {
                        chDirectory = newDirectory.GetRange(0, newDirectory.LastIndexOf("Files:"));

                        if (chDirectory.Count == 0)
                        {
                            Console.WriteLine("There are no folders here.");
                            return true;
                        }
                        return false;
                    }
                    else
                    {
                        chDirectory = newDirectory.GetRange(newDirectory.LastIndexOf("Files:") + 1, newDirectory.Count - (newDirectory.LastIndexOf("Files:") + 1));

                        if (chDirectory.Count == 0)
                        {
                            Console.WriteLine("There are no files here.");
                            return true;
                        }
                        return false;
                    }

                }

                string myPlace = "";
                List<string> newDirectory = new List<string>();
                List<string> chDirectory = new List<string>();
                bool exit = false;
                int chose = 0;
                string placeForBack = "";

                while (true)
                {
                    var drives = ViewDrive();
                    Console.WriteLine("Now you can olny open chosen drive.");
                    myPlace += ChoseDrive(drives, out exit);
                    if (exit == true) break;
                    newDirectory = OpenFolder(myPlace);

                    while (!exit)
                    {
                        Console.WriteLine("Chose what you want:\n[1] Open; [2] Back; [3] Create; [4] Copy; [5] Delete; [6] Rename; [7] Remove.");
                        chose = ChoseAction(7);
                        switch (chose)
                        {
                            case 1:
                                chDirectory = newDirectory.GetRange(0, newDirectory.LastIndexOf("Files:"));
                                Open(ref chDirectory, ref newDirectory, ref myPlace, ref placeForBack);
                                break;
                            case 2:
                                int sleh = 0;
                                int sch = 0;
                                int secEx = 0;

                                while ((sch = myPlace.IndexOf("\\", sch)) != -1)
                                {
                                    ++sleh;
                                    sch += 1;
                                }

                                if (sleh == 1) secEx++;

                                if (placeForBack == "" || secEx == 2)
                                {
                                    exit = true;
                                    break;
                                }

                                newDirectory = CloseFolder(placeForBack);
                                myPlace = placeForBack;
                                placeForBack = BackForw(myPlace, placeForBack);
                                break;
                            case 3:
                                Console.WriteLine("Chose what you want to create:\n[1] Folder; [2] File; [3] Back.");
                                chose = ChoseAction(3);
                                switch (chose)
                                {
                                    case 1:
                                        Console.WriteLine("Enter a name for the new folder.");
                                        string newFolder = Console.ReadLine();

                                        if (string.IsNullOrEmpty(newFolder))
                                        {
                                            Console.WriteLine("Incorrect name for new folder.");
                                        }

                                        if (!Directory.Exists($"{myPlace}\\{newFolder}") && !File.Exists($"{myPlace}\\{newFolder}"))
                                        {
                                            Directory.CreateDirectory($"{myPlace}\\{newFolder}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Such folder or file already exists or the name contains invalid characters.");
                                        }
                                        break;
                                    case 2:
                                        Console.WriteLine("Enter a name for the new file.");
                                        string newFile = Console.ReadLine();

                                        if (string.IsNullOrEmpty(newFile))
                                        {
                                            Console.WriteLine("Incorrect name for new file.");
                                        }

                                        if (!File.Exists($"{myPlace}\\{newFile}") && !Directory.Exists($"{myPlace}\\{newFile}"))
                                        {
                                            using (File.Create($"{myPlace}\\{newFile}"))
                                            { }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Such folder or file already exists or the name contains invalid characters.");
                                        }
                                        break;
                                }

                                newDirectory = OpenFolder(myPlace);
                                break;
                            case 4:
                                int numCopy = 1;
                                bool copyCreate = false;
                                int removeIndex;
                                string copyFolder = "";

                                Console.WriteLine("Chose what copy you want to create:\n[1] Folder; [2] File; [3] Back.");
                                chose = ChoseAction(3);

                                switch (chose)
                                {
                                    case 1:
                                        if (NoFolderFile(1, ref chDirectory, ref newDirectory)) break;

                                        copyFolder = ChoseFolder(chDirectory) + $" - (Copy {numCopy})";

                                        while (!copyCreate)
                                        {
                                            if (!Directory.Exists(copyFolder) && !File.Exists(copyFolder))
                                            {
                                                Directory.CreateDirectory(copyFolder);
                                                copyCreate = true;
                                                newDirectory = CloseFolder(myPlace);
                                            }
                                            else
                                            {
                                                ++numCopy;
                                                removeIndex = copyFolder.LastIndexOf($"{numCopy - 1}");
                                                copyFolder = copyFolder.Remove(removeIndex, (numCopy - 1).ToString().Length).Insert(removeIndex, $"{numCopy}");
                                            }
                                        }
                                        break;
                                    case 2:
                                        if (NoFolderFile(2, ref chDirectory, ref newDirectory)) break;

                                        copyFolder = ChoseFolder(chDirectory) + $" - (Copy {numCopy})";

                                        while (!copyCreate)
                                        {
                                            if (!File.Exists(copyFolder) && !Directory.Exists(copyFolder))
                                            {
                                                using (File.Create(copyFolder))
                                                { }
                                                copyCreate = true;
                                                newDirectory = CloseFolder(myPlace);
                                            }
                                            else
                                            {
                                                ++numCopy;
                                                removeIndex = copyFolder.LastIndexOf($"{numCopy - 1}");
                                                copyFolder = copyFolder.Remove(removeIndex, (numCopy - 1).ToString().Length).Insert(removeIndex, $"{numCopy}");
                                            }
                                        }
                                        break;
                                }
                                break;
                            case 5:
                                string deleteDir = "";

                                Console.WriteLine("Chose what you want to delete:\n[1] Folder; [2] File; [3] Back.");
                                chose = ChoseAction(3);

                                switch (chose)
                                {
                                    case 1:
                                        if (NoFolderFile(1, ref chDirectory, ref newDirectory)) break;

                                        deleteDir = ChoseFolder(chDirectory);

                                        if (Directory.Exists(deleteDir))
                                        {
                                            Directory.Delete(deleteDir, true);
                                            newDirectory = CloseFolder(myPlace);
                                        }
                                        break;
                                    case 2:
                                        if (NoFolderFile(2, ref chDirectory, ref newDirectory)) break;

                                        deleteDir = ChoseFolder(chDirectory);

                                        if (File.Exists(deleteDir))
                                        {
                                            File.Delete(deleteDir);
                                            newDirectory = CloseFolder(myPlace);
                                        }
                                        break;
                                }
                                break;
                            case 6:
                                string oldPath = "";
                                string newPath = "";

                                Console.WriteLine("Chose what you want to rename:\n[1] Folder; [2] File; [3] Back.");
                                chose = ChoseAction(3);

                                switch (chose)
                                {
                                    case 1:
                                        if (NoFolderFile(1, ref chDirectory, ref newDirectory)) break;

                                        oldPath = ChoseFolder(chDirectory);
                                        Console.WriteLine("Write a new folder name.");
                                        newPath = Console.ReadLine();

                                        if (string.IsNullOrEmpty(newPath))
                                        {
                                            Console.WriteLine("Incorrect name for new folder.");
                                            break;
                                        }

                                        if (Directory.Exists(oldPath) && !Directory.Exists(newPath) && !File.Exists(newPath))
                                        {
                                            Directory.Move(oldPath, $"{myPlace}\\{newPath}");
                                            newDirectory = CloseFolder(myPlace);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Such name of file or folder already exists.");
                                        }
                                        break;
                                    case 2:
                                        if (NoFolderFile(2, ref chDirectory, ref newDirectory)) break;

                                        oldPath = ChoseFolder(chDirectory);
                                        Console.WriteLine("Write a new file name.");
                                        newPath = Console.ReadLine();

                                        if (string.IsNullOrEmpty(newPath))
                                        {
                                            Console.WriteLine("Incorrect name for new file.");
                                            break;
                                        }

                                        if (File.Exists(oldPath) && !File.Exists(newPath) && !Directory.Exists(newPath))
                                        {
                                            File.Move(oldPath, $"{myPlace}\\{newPath}");
                                            newDirectory = CloseFolder(myPlace);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Such name of file or folder already exists.");
                                        }
                                        break;
                                }
                                break;
                            case 7:
                                bool chosen = false;
                                int filOrFol;

                                Console.WriteLine("Chose what you want to remove:\n[1] Folder; [2] File; [3] Back.");
                                chose = ChoseAction(3);
                                filOrFol = chose;

                                switch (chose)
                                {
                                    case 1:
                                        chosen = NoFolderFile(1, ref chDirectory, ref newDirectory);

                                        break;
                                    case 2:
                                        chosen = NoFolderFile(2, ref chDirectory, ref newDirectory);

                                        break;
                                    case 3:
                                        chosen = true;
                                        break;
                                }

                                string replaceFolder = "";

                                if (!chosen)
                                {
                                    replaceFolder = ChoseFolder(chDirectory);
                                }

                                string nameFolder;

                                int finishWord = replaceFolder.Length;
                                int startWord = replaceFolder.LastIndexOf('\\') + 1;
                                nameFolder = replaceFolder.Substring(startWord, finishWord - startWord);

                                string curPlace = myPlace;
                                string curPlaceForBack = placeForBack;
                                List<string> curNewDirectory = newDirectory;

                                while (!chosen)
                                {
                                    Console.WriteLine($"Removed: {nameFolder}");
                                    Console.WriteLine("Chose what you want:\n[1] Open; [2] Back; [3] Push here; [4] Exit.");
                                    chose = ChoseAction(4);

                                    switch (chose)
                                    {
                                        case 1:
                                            Open(ref curNewDirectory, ref curNewDirectory, ref curPlace, ref curPlaceForBack);
                                            break;
                                        case 2:

                                            int sleh2 = 0;
                                            int sch2 = 0;
                                            int secEx2 = 0;

                                            while ((sch2 = curPlace.IndexOf("\\", sch2)) != -1)
                                            {
                                                ++sleh2;
                                                sch2 += 1;
                                            }

                                            if (sleh2 == 1) secEx2++;

                                            if (curPlaceForBack == "" || secEx2 == 2)
                                            {
                                                ViewDrive();
                                                Console.WriteLine("Now you can olny open chosen drive.");
                                                curPlace = ChoseDrive(drives);
                                                curNewDirectory = OpenFolder(curPlace);
                                                break;
                                            }

                                            curNewDirectory = CloseFolder(curPlaceForBack);
                                            curPlace = curPlaceForBack;
                                            curPlaceForBack = BackForw(curPlace, curPlaceForBack);
                                            break;
                                        case 3:
                                            switch (filOrFol)
                                            {
                                                case 1:
                                                    if (!Directory.Exists($"{curPlace}\\{nameFolder}") && !File.Exists($"{curPlace}\\{nameFolder}"))
                                                    {
                                                        Directory.Move(replaceFolder, $"{curPlace}\\{nameFolder}");
                                                        Console.WriteLine("Removed.");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Such folder or file already exists or the name contains invalid characters.");
                                                    }

                                                    newDirectory = CloseFolder(myPlace);
                                                    chosen = true;
                                                    break;
                                                case 2:
                                                    if (!File.Exists($"{curPlace}\\{nameFolder}") && !Directory.Exists($"{curPlace}\\{nameFolder}"))
                                                    {
                                                        File.Move(replaceFolder, $"{curPlace}\\{nameFolder}");
                                                        Console.WriteLine("Removed.");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Such file or folder already exists or the name contains invalid characters.");
                                                    }

                                                    newDirectory = CloseFolder(myPlace);
                                                    chosen = true;
                                                    break;
                                            }

                                            break;
                                        case 4:
                                            newDirectory = CloseFolder(myPlace);
                                            chosen = true;
                                            break;
                                    }
                                }
                                break;
                        }
                    }
                    myPlace = "";
                    exit = false;
                }
                Console.WriteLine();
            }
            catch (IOException)
            {
                Console.WriteLine("You do not have enough access rights");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You do not have enough access rights");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown exeption");
            }
        }
    }
}