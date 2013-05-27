﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xIMU_API
{
    /// <summary>
    /// Calibrated gyroscope, accelerometer and magnetometer data class.
    /// </summary>
    public class CalInertialMagData : xIMUdata
    {
        #region Variables

        private float[] privGyroscope;
        private float[] privAccelerometer;
        private float[] privMagnetometer;

        #endregion

        #region Properties

        /// <summary>
        /// Calibrated gyroscope data in degrees per second.  Elements 0, 1 and 2 represent the sensor x, y and z axes respectively.
        /// </summary>
        public float[] Gyroscope
        {
            get
            {
                return privGyroscope;
            }
            set
            {
                privGyroscope = value;
            }
        }

        /// <summary>
        /// Calibrated accelerometer data in 'g'.  Elements 0, 1 and 2 represent the sensor x, y and z axes respectively.
        /// </summary>
        public float[] Accelerometer
        {
            get
            {
                return privAccelerometer;
            }
            set
            {
                privAccelerometer = value;
            }
        }

        /// <summary>
        /// Calibrated magnetometer data in Gauss.  Elements 0, 1 and 2 represent the sensor x, y and z axes respectively.
        /// </summary>
        public float[] Magnetometer
        {
            get
            {
                return privMagnetometer;
            }
            set
            {
                privMagnetometer = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="CalInertialMagData"/> class.
        /// </summary>
        public CalInertialMagData()
            : this(new float[3] { 0, 0, 0 }, new float[3] { 0, 0, 0 }, new float[3] { 0, 0, 0 })
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="CalInertialMagData"/> class.
        /// </summary>
        /// <param name="gyroscope">
        /// Calibrated gyroscope data in degrees per second.  Elements 0, 1 and 2 represent the sensor x, y and z axes respectively.
        /// </param>
        /// <param name="accelerometer">
        /// Calibrated accelerometer data in 'g'.  Elements 0, 1 and 2 represent the sensor x, y and z axes respectively.
        /// </param>  
        /// <param name="magnetometer">
        /// Calibrated magnetometer data in Gauss.  Elements 0, 1 and 2 represent the sensor x, y and z axes respectively.
        /// </param>  
        public CalInertialMagData(float[] gyroscope, float[] accelerometer, float[] magnetometer)
        {
            Gyroscope = gyroscope;
            Accelerometer = accelerometer;
            Magnetometer = magnetometer;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Converts data to string of Comma Separated Variables.
        /// </summary>
        public string ConvertToCSV()
        {
            return Convert.ToString(Gyroscope[0]) + "," + Convert.ToString(Gyroscope[1]) + "," + Convert.ToString(Gyroscope[2]) + "," +
                   Convert.ToString(Accelerometer[0]) + "," + Convert.ToString(Accelerometer[1]) + "," + Convert.ToString(Accelerometer[2]) + "," +
                   Convert.ToString(Magnetometer[0]) + "," + Convert.ToString(Magnetometer[1]) + "," + Convert.ToString(Magnetometer[2]);
        }

        #endregion
    }
}
