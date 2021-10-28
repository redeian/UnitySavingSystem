using System.Collections;
using UnityEngine;

using MW.Saving;

namespace MDRPG.SceneManagement
{

    public class SavingWarpper : MonoBehaviour
    {
        const string defaultSaveFile = "save";

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                print("load save");
                Load();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                Save();

            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                Delete();
            }
        }

        public void Save()
        {
            GetComponent<SavingSystem>().Save(defaultSaveFile);
        }

        public void Load()
        {
            GetComponent<SavingSystem>().Load(defaultSaveFile);
        }

        public void Delete()
        {
            GetComponent<SavingSystem>().Delete(defaultSaveFile);
        }
    }

}