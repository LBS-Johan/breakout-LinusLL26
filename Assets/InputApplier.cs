using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputApplier : MonoBehaviour
{
    public int Int32;
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public void Start()
    {
        moveLeft = LeftKeyGet(Int32);
    }
    
    public KeyCode RightKeyGet(int keyNumber)
    {
        
        if (keyNumber == 1)
        {
            return KeyCode.Q;
        } 
        if (keyNumber == 2)
        {
            return KeyCode.W;
        } 
        if (keyNumber == 3)
        {
            return KeyCode.E;
        } 
        if (keyNumber == 4)
        {
            return KeyCode.R;
        } 
        if (keyNumber == 5)
        {
            return KeyCode.T;
        } 
        if (keyNumber == 6)
        {
            return KeyCode.Y;
        } 
        if (keyNumber == 7)
        {
            return KeyCode.U;
        } 
        if (keyNumber == 8)
        {
            return KeyCode.I;
        } 
        if (keyNumber == 9)
        {
            return KeyCode.O;
        } 
        if (keyNumber == 10)
        {
            return KeyCode.P;
        } 
        if (keyNumber == 11)
        {
            return KeyCode.A;
        } 
        if (keyNumber == 12)
        {
            return KeyCode.S;
        } 
        if (keyNumber == 13)
        {
            return KeyCode.D;
        } 
        if (keyNumber == 14)
        {
            return KeyCode.F;
        } 
        if (keyNumber == 15)
        {
            return KeyCode.G;
        } 
        if (keyNumber == 16)
        {
            return KeyCode.H;
        } 
        if (keyNumber == 17)
        {
            return KeyCode.J;
        } 
        if (keyNumber == 18)
        {
            return KeyCode.K;
        } 
        if (keyNumber == 19)
        {
            return KeyCode.L;
        } 
        if (keyNumber == 20)
        {
            return KeyCode.Z;
        } 
        if (keyNumber == 21)
        {
            return KeyCode.X;
        } 
        if (keyNumber == 22)
        {
            return KeyCode.C;
        } 
        if (keyNumber == 23)
        {
            return KeyCode.V;
        } 
        if (keyNumber == 24)
        {
            return KeyCode.B;
        } 
        if (keyNumber == 25)
        {
            return KeyCode.N;
        } 
        if (keyNumber == 26)
        {
            return KeyCode.M;
        } 
        if (keyNumber == 27)
        {
            return KeyCode.LeftArrow;
        }
        if (keyNumber == 28)
        {
            return KeyCode.RightArrow;
        }
        else
        {
            return moveRight;
        }
            
    }   public KeyCode LeftKeyGet(int keyNumber)
    {

        if (keyNumber == 1)
        {
            return KeyCode.Q;
        }
        if (keyNumber == 2)
        {
            return KeyCode.W;
        }
        if (keyNumber == 3)
        {
            return KeyCode.E;
        }
        if (keyNumber == 4)
        {
            return KeyCode.R;
        }
        if (keyNumber == 5)
        {
            return KeyCode.T;
        }
        if (keyNumber == 6)
        {
            return KeyCode.Y;
        }
        if (keyNumber == 7)
        {
            return KeyCode.U;
        }
        if (keyNumber == 8)
        {
            return KeyCode.I;
        }
        if (keyNumber == 9)
        {
            return KeyCode.O;
        }
        if (keyNumber == 10)
        {
            return KeyCode.P;
        }
        if (keyNumber == 11)
        {
            return KeyCode.A;
        }
        if (keyNumber == 12)
        {
            return KeyCode.S;
        }
        if (keyNumber == 13)
        {
            return KeyCode.D;
        }
        if (keyNumber == 14)
        {
            return KeyCode.F;
        }
        if (keyNumber == 15)
        {
            return KeyCode.G;
        }
        if (keyNumber == 16)
        {
            return KeyCode.H;
        }
        if (keyNumber == 17)
        {
            return KeyCode.J;
        }
        if (keyNumber == 18)
        {
            return KeyCode.K;
        }
        if (keyNumber == 19)
        {
            return KeyCode.L;
        }
        if (keyNumber == 20)
        {
            return KeyCode.Z;
        }
        if (keyNumber == 21)
        {
            return KeyCode.X;
        }
        if (keyNumber == 22)
        {
            return KeyCode.C;
        }
        if (keyNumber == 23)
        {
            return KeyCode.V;
        }
        if (keyNumber == 24)
        {
            return KeyCode.B;
        }
        if (keyNumber == 25)
        {
            return KeyCode.N;
        }
        if (keyNumber == 26)
        {
            return KeyCode.M;
        }
        if (keyNumber == 27)
        {
            return KeyCode.LeftArrow;
        }
        if (keyNumber == 28)
        {
            return KeyCode.RightArrow;
        }
        else
        {
            return moveLeft;
        }

    }
}
