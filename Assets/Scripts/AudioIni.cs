using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class AudioIni : MonoBehaviour

{
    AudioSource _fuenteDeAudio; //_audioSource
    public static float[] _muestraSampling = new float[512];
    public static float[] _bandaFrecuencia =  new float[8];
    // Start is called before the first frame update
    void Start()
    {
        _fuenteDeAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
        MakeFrequencyBands();
    }

    // Update call (los metodos de abajo xd)
    void GetSpectrumAudioSource()
    {
        _fuenteDeAudio.GetSpectrumData(_muestraSampling, 0, FFTWindow.Blackman
        );
    }
    void MakeFrequencyBands()
    {

        int count = 0;
        for (int i = 0; i <8; i++)
        {

            float averagePromedio = 0;
            int recuentoDeMuestra = (int)Mathf.Pow(2,i) * 2;

            if( i == 7)
            {
                recuentoDeMuestra +=2;
            }
            for(int j = 0; j < recuentoDeMuestra; j++)
            {
                averagePromedio += _muestraSampling[count] *(count+1);
                    count++;
            }
            averagePromedio /= count;
            _bandaFrecuencia[i] = averagePromedio * 10;

        }
    }
}
