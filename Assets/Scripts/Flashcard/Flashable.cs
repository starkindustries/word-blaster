﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Flashable
{
    Flashcard card { get; }

    void SetFlashcard(Flashcard card);
}
